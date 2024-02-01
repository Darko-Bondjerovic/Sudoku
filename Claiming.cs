using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuNS
{
    public class Item
    {
        public List<Pair> list = null;
        public int count = 0;
        
        public override string ToString()
        {
            return $"\n[{string.Join("|", list)}]={count}\n";
        }
    }
    
    public class Claiming
    {
        Sudoku su = null;

        string removedItemStr = "";
        
        public int box = 0;
        public int candy = 1;
        public int kind = 0; //0-in row, 1-in coll (see Pairs class)

        public Action<string> ConsoleWrite = (s) => { };
        
        public bool Pointing = false;
        
        public Claiming(Sudoku su)
        {
            this.su = su;
        }

        public override string ToString()
        {
            return $"candy: {candy}, box: {box}, kind {kind}\n";
        }
        
        public int GetCandySum(List<Pair> list)
        {
            var calc = new List<List<int>>();
            foreach (var l in list)
                calc.Add(su.calc_candidates[l.j, l.i]);

            return calc.Count(x => x.Contains(candy));
        }

        public List<Pair> Make3FieldsList(int indx)
        {
            var result = new List<Pair>();

            var fj = 3 * (box / 3);
            var fi = 3 * (box % 3);

            var y = fj + indx;
            var x = fi + indx;

            var start = kind == 0 ? fi : fj;

            for (int n = start; n < start + 3; n++)
            {
                if (kind == 0) x = n; else y = n;
                result.Add(new Pair(y, x, kind));
            }

            return result;
        }

        public List<Pair> FindRest(List<Pair> list)
        {
            Pair first = list[0];

            return su.pairs[first.j, first.i]
                .Where(x => x.kind == first.kind)
                .Except(list).ToList();
        }
            
        private void RemoveCandidate(Pair r)
        {
            if (!su.calc_candidates[r.j, r.i].Contains(candy))
                return;
            
            ConsoleWrite(r.ToString() + ": ");
            ConsoleWrite(string.Join("|", su.calc_candidates[r.j, r.i]));
                                        
            su.hitx = r.i;
            su.hity = r.j;
            su.HandleUserCandidates(candy);
                                          
            ConsoleWrite(" -> " + string.Join("|", su.calc_candidates[r.j, r.i]) + "\n");
        }

        List<Item> Get3ListsWithCount()
        {
            List<Item> result = new List<Item>();
            
            for (int i = 0; i < 3; i++)
            {
                var item = new Item();
                item.list = Make3FieldsList(i);
                item.count = GetCandySum(item.list);
            
                result.Add(item);
            }
            
            return result;
        }
        
        public List<Item> FindToRemoveCliming()
        {
            var items = Get3ListsWithCount();
            
            foreach (var item in items)
            {
                if (item.count > 1) //count = 2 or 3
                {
                    if (GetCandySum(FindRest(item.list)) == 0)
                    {
                        removedItemStr = item.ToString();
                        items.Remove(item);
                        break;
                    }
                }
            }

            return items;
        }
        
        public List<Pair> FindToRemovePointing()
        {
            // descending list, e.g. counts: 2,0,0
            var sort = Get3ListsWithCount()
                .OrderByDescending(x => x.count)
                .ToList();
                
            // extract only counts:
            var cnt = sort.Select( x => x.count).ToArray();
            
            // only one row/col should have count 2 or 3, and rest is 0:
            if (cnt[0] > 1 && (cnt[1] + cnt[2] == 0))
            {
                var rest = FindRest(sort[0].list);
                if (GetCandySum(rest) > 0)
                {
                    ConsoleWrite(sort[0].ToString()); 
                    return rest;
                }
            }
            
            return null;
        }
        
        public void RemoveOnePointing()
        {
            var toRemove = FindToRemovePointing();
                
            if (toRemove == null)
                return;
            
            ConsoleWrite(this.ToString());
            foreach(var r in toRemove)
                RemoveCandidate(r);
        }
        
        public void RemoveOneClaiming()
        {
            var toRemove = FindToRemoveCliming();

            // only 2 rows/cols remain
            if (toRemove.Count == 2)
            {
                foreach (var item in toRemove)
                {
                    if (item.count == 0)
                        continue;
                    
                    ConsoleWrite(removedItemStr);
                    ConsoleWrite(this.ToString());
                    
                    foreach (var r in item.list)
                        RemoveCandidate(r);
                }
            }
        }

        public void RemoveAll(bool claim = true)
        {
            var oldhitx = su.hitx;
            var oldhity = su.hity;
            
            for (int candy = 1; candy <= 9; candy++)
            {
                for (int box = 0; box < 9; box++)
                {
                    for (int kind = 0; kind < 2; kind++)
                    {
                        this.box = box;
                        this.candy = candy;
                        this.kind = kind;
                       
                        if (claim)
                            RemoveOneClaiming();
                        else
                            RemoveOnePointing();
                    }
                }
            }
            
            su.hitx = oldhitx;
            su.hity = oldhity;
        }
    }
}