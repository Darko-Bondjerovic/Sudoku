<?xml version="1.0" encoding="utf-8"?>
<Tests>
  <GroupItem>
    <name>Cla Pnt Tests</name>
    <pass>true</pass>
    <act></act>
    <exp></exp>
    <TestItem>
      <name>Box First Cells coords</name>
      <pass>true</pass>
      <act>0:[0,0]  1:[0,3]  2:[0,6]  
3:[3,0]  4:[3,3]  5:[3,6]  
6:[6,0]  7:[6,3]  8:[6,6]  
</act>
      <exp>0:[0,0]  1:[0,3]  2:[0,6]  
3:[3,0]  4:[3,3]  5:[3,6]  
6:[6,0]  7:[6,3]  8:[6,6]  
</exp>
    </TestItem>
    <TestItem>
      <name>3 fields list, box: 1 kind: 0</name>
      <pass>true</pass>
      <act>y:0, x:3
start: 3
[0,3][0,4][0,5]</act>
      <exp>y:0, x:3
start: 3
[0,3][0,4][0,5]</exp>
    </TestItem>
    <TestItem>
      <name>3 fields list, box: 6 kind: 1</name>
      <pass>true</pass>
      <act>y:6, x:0
start: 6
[6,0]
[7,0]
[8,0]
</act>
      <exp>y:6, x:0
start: 6
[6,0]
[7,0]
[8,0]
</exp>
    </TestItem>
    <TestItem>
      <name>3 Fields List in box: 5 kind: 0</name>
      <pass>true</pass>
      <act>indx: 0 -&gt; [0:3,6|0:3,7|0:3,8]
indx: 1 -&gt; [0:4,6|0:4,7|0:4,8]
indx: 2 -&gt; [0:5,6|0:5,7|0:5,8]
</act>
      <exp>indx: 0 -&gt; [0:3,6|0:3,7|0:3,8]
indx: 1 -&gt; [0:4,6|0:4,7|0:4,8]
indx: 2 -&gt; [0:5,6|0:5,7|0:5,8]
</exp>
    </TestItem>
    <TestItem>
      <name>3 Fields List in box: 5 kind: 1</name>
      <pass>true</pass>
      <act>indx: 0 -&gt; [1:3,6|1:4,6|1:5,6]
indx: 1 -&gt; [1:3,7|1:4,7|1:5,7]
indx: 2 -&gt; [1:3,8|1:4,8|1:5,8]
</act>
      <exp>indx: 0 -&gt; [1:3,6|1:4,6|1:5,6]
indx: 1 -&gt; [1:3,7|1:4,7|1:5,7]
indx: 2 -&gt; [1:3,8|1:4,8|1:5,8]
</exp>
    </TestItem>
    <TestItem>
      <name>Sum for candy: 7, box: 5, kind 0</name>
      <pass>true</pass>
      <act>
 indx: 0 -&gt; SUM: 2
 indx: 1 -&gt; SUM: 1
 indx: 2 -&gt; SUM: 2
</act>
      <exp>
 indx: 0 -&gt; SUM: 2
 indx: 1 -&gt; SUM: 1
 indx: 2 -&gt; SUM: 2
</exp>
    </TestItem>
    <TestItem>
      <name>Sum for candy: 7, box: 5, kind 1</name>
      <pass>true</pass>
      <act>
 indx: 0 -&gt; SUM: 3
 indx: 1 -&gt; SUM: 0
 indx: 2 -&gt; SUM: 2
</act>
      <exp>
 indx: 0 -&gt; SUM: 3
 indx: 1 -&gt; SUM: 0
 indx: 2 -&gt; SUM: 2
</exp>
    </TestItem>
    <TestItem>
      <name>TestRemoveOneClaiming</name>
      <pass>true</pass>
      <act>
[1:3,6|1:4,6|1:5,6]=3
candy: 7, box: 5, kind 1
1:3,8: 1|4|7|8|9 -&gt; 1|4|8|9
1:5,8: 1|3|4|5|7 -&gt; 1|3|4|5
</act>
      <exp>
[1:3,6|1:4,6|1:5,6]=3
candy: 7, box: 5, kind 1
1:3,8: 1|4|7|8|9 -&gt; 1|4|8|9
1:5,8: 1|3|4|5|7 -&gt; 1|3|4|5
</exp>
    </TestItem>
    <TestItem>
      <name>TestRemoveAllClaimnigs</name>
      <pass>true</pass>
      <act>=== Claiming: True ===
[1:6,8|1:7,8|1:8,8]=3
candy: 2, box: 8, kind 1
1:7,6: 2|5|8|9 -&gt; 5|8|9

[1:6,0|1:7,0|1:8,0]=2
candy: 3, box: 6, kind 1
1:7,2: 1|2|3|5|8|9 -&gt; 1|2|5|8|9
1:8,2: 2|3|5|8|9 -&gt; 2|5|8|9

[0:4,0|0:4,1|0:4,2]=2
candy: 4, box: 3, kind 0
0:5,0: 1|4|6 -&gt; 1|6

[1:6,3|1:7,3|1:8,3]=2
candy: 6, box: 7, kind 1
1:8,5: 2|5|6|8 -&gt; 2|5|8

[1:3,6|1:4,6|1:5,6]=3
candy: 7, box: 5, kind 1
1:3,8: 1|4|7|8|9 -&gt; 1|4|8|9
1:5,8: 1|3|4|5|7 -&gt; 1|3|4|5
</act>
      <exp>=== Claiming: True ===
[1:6,8|1:7,8|1:8,8]=3
candy: 2, box: 8, kind 1
1:7,6: 2|5|8|9 -&gt; 5|8|9

[1:6,0|1:7,0|1:8,0]=2
candy: 3, box: 6, kind 1
1:7,2: 1|2|3|5|8|9 -&gt; 1|2|5|8|9
1:8,2: 2|3|5|8|9 -&gt; 2|5|8|9

[0:4,0|0:4,1|0:4,2]=2
candy: 4, box: 3, kind 0
0:5,0: 1|4|6 -&gt; 1|6

[1:6,3|1:7,3|1:8,3]=2
candy: 6, box: 7, kind 1
1:8,5: 2|5|6|8 -&gt; 2|5|8

[1:3,6|1:4,6|1:5,6]=3
candy: 7, box: 5, kind 1
1:3,8: 1|4|7|8|9 -&gt; 1|4|8|9
1:5,8: 1|3|4|5|7 -&gt; 1|3|4|5
</exp>
    </TestItem>
    <TestItem>
      <name>2.TestRemoveAllClaimnigs</name>
      <pass>true</pass>
      <act>=== Claiming: True ===
[1:6,0|1:7,0|1:8,0]=2
candy: 4, box: 6, kind 1
1:7,2: 2|4|5|6 -&gt; 2|5|6
1:8,2: 2|3|4|5|7 -&gt; 2|3|5|7

[0:7,0|0:7,1|0:7,2]=2
candy: 5, box: 6, kind 0
0:6,1: 2|5|6 -&gt; 2|6

[0:7,0|0:7,1|0:7,2]=2
candy: 5, box: 6, kind 0
0:8,2: 2|3|5|7 -&gt; 2|3|7

[0:8,3|0:8,4|0:8,5]=2
candy: 5, box: 7, kind 0
0:6,4: 2|5|6 -&gt; 2|6

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:0,0: 2|7 -&gt; 2
0:0,2: 2|6|7 -&gt; 2|6

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:2,2: 2|3|5|6|7|8 -&gt; 2|3|5|6|8

[1:3,8|1:4,8|1:5,8]=2
candy: 8, box: 5, kind 1
1:3,6: 1|4|5|8|9 -&gt; 1|4|5|9

[1:3,5|1:4,5|1:5,5]=3
candy: 9, box: 4, kind 1
1:4,3: 4|6|9 -&gt; 4|6
1:5,3: 3|4|6|7|9 -&gt; 3|4|6|7

[1:3,7|1:4,7|1:5,7]=3
candy: 9, box: 5, kind 1
1:3,6: 1|4|5|9 -&gt; 1|4|5
</act>
      <exp>=== Claiming: True ===
[1:6,0|1:7,0|1:8,0]=2
candy: 4, box: 6, kind 1
1:7,2: 2|4|5|6 -&gt; 2|5|6
1:8,2: 2|3|4|5|7 -&gt; 2|3|5|7

[0:7,0|0:7,1|0:7,2]=2
candy: 5, box: 6, kind 0
0:6,1: 2|5|6 -&gt; 2|6

[0:7,0|0:7,1|0:7,2]=2
candy: 5, box: 6, kind 0
0:8,2: 2|3|5|7 -&gt; 2|3|7

[0:8,3|0:8,4|0:8,5]=2
candy: 5, box: 7, kind 0
0:6,4: 2|5|6 -&gt; 2|6

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:0,0: 2|7 -&gt; 2
0:0,2: 2|6|7 -&gt; 2|6

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:2,2: 2|3|5|6|7|8 -&gt; 2|3|5|6|8

[1:3,8|1:4,8|1:5,8]=2
candy: 8, box: 5, kind 1
1:3,6: 1|4|5|8|9 -&gt; 1|4|5|9

[1:3,5|1:4,5|1:5,5]=3
candy: 9, box: 4, kind 1
1:4,3: 4|6|9 -&gt; 4|6
1:5,3: 3|4|6|7|9 -&gt; 3|4|6|7

[1:3,7|1:4,7|1:5,7]=3
candy: 9, box: 5, kind 1
1:3,6: 1|4|5|9 -&gt; 1|4|5
</exp>
    </TestItem>
    <TestItem>
      <name>TestFindPointing</name>
      <pass>true</pass>
      <act>candy: 5, box: 4, kind 0


[0:4,3|0:4,4|0:4,5]=2
----------
0:4,0
0:4,1
0:4,2
0:4,6
0:4,7
0:4,8
----------
3
----------
</act>
      <exp>candy: 5, box: 4, kind 0


[0:4,3|0:4,4|0:4,5]=2
----------
0:4,0
0:4,1
0:4,2
0:4,6
0:4,7
0:4,8
----------
3
----------
</exp>
    </TestItem>
    <TestItem>
      <name>TestRemoveOnePointing</name>
      <pass>true</pass>
      <act>
[0:4,3|0:4,4|0:4,5]=2
candy: 5, box: 4, kind 0
0:4,1: 1|2|5|6|7|8 -&gt; 1|2|6|7|8
0:4,6: 1|2|5|6|7 -&gt; 1|2|6|7
0:4,8: 1|5|6 -&gt; 1|6
</act>
      <exp>
[0:4,3|0:4,4|0:4,5]=2
candy: 5, box: 4, kind 0
0:4,1: 1|2|5|6|7|8 -&gt; 1|2|6|7|8
0:4,6: 1|2|5|6|7 -&gt; 1|2|6|7
0:4,8: 1|5|6 -&gt; 1|6
</exp>
    </TestItem>
    <TestItem>
      <name>TestRemoveAllPointings</name>
      <pass>true</pass>
      <act>=== Claiming: False ===
[1:6,6|1:7,6|1:8,6]=3
candy: 2, box: 8, kind 1
1:3,6: 2|5|6|7|9 -&gt; 5|6|7|9
1:4,6: 1|2|5|6|7 -&gt; 1|5|6|7

[0:4,3|0:4,4|0:4,5]=2
candy: 5, box: 4, kind 0
0:4,1: 1|2|5|6|7|8 -&gt; 1|2|6|7|8
0:4,6: 1|5|6|7 -&gt; 1|6|7
0:4,8: 1|5|6 -&gt; 1|6

[0:1,6|0:1,7|0:1,8]=2
candy: 7, box: 2, kind 0
0:1,0: 1|2|3|7 -&gt; 1|2|3
0:1,1: 1|2|3|7 -&gt; 1|2|3
</act>
      <exp>=== Claiming: False ===
[1:6,6|1:7,6|1:8,6]=3
candy: 2, box: 8, kind 1
1:3,6: 2|5|6|7|9 -&gt; 5|6|7|9
1:4,6: 1|2|5|6|7 -&gt; 1|5|6|7

[0:4,3|0:4,4|0:4,5]=2
candy: 5, box: 4, kind 0
0:4,1: 1|2|5|6|7|8 -&gt; 1|2|6|7|8
0:4,6: 1|5|6|7 -&gt; 1|6|7
0:4,8: 1|5|6 -&gt; 1|6

[0:1,6|0:1,7|0:1,8]=2
candy: 7, box: 2, kind 0
0:1,0: 1|2|3|7 -&gt; 1|2|3
0:1,1: 1|2|3|7 -&gt; 1|2|3
</exp>
    </TestItem>
  </GroupItem>
  <GroupItem>
    <name>Find all tests</name>
    <pass>true</pass>
    <act></act>
    <exp></exp>
    <TestItem>
      <name>Test 59.7..4..8..4..3</name>
      <pass>true</pass>
      <act>=== Claiming: False ===
[1:0,5|1:1,5|1:2,5]=2
candy: 6, box: 1, kind 1
1:8,5: 2|5|6|8 -&gt; 2|5|8
=== Claiming: True ===
[1:6,8|1:7,8|1:8,8]=3
candy: 2, box: 8, kind 1
1:7,6: 2|5|8|9 -&gt; 5|8|9

[1:6,0|1:7,0|1:8,0]=2
candy: 3, box: 6, kind 1
1:7,2: 1|2|3|5|8|9 -&gt; 1|2|5|8|9
1:8,2: 2|3|5|8|9 -&gt; 2|5|8|9

[0:4,0|0:4,1|0:4,2]=2
candy: 4, box: 3, kind 0
0:5,0: 1|4|6 -&gt; 1|6

[1:3,6|1:4,6|1:5,6]=3
candy: 7, box: 5, kind 1
1:3,8: 1|4|7|8|9 -&gt; 1|4|8|9
1:5,8: 1|3|4|5|7 -&gt; 1|3|4|5
Call calculate candidates!
0 [0,2] diff: 3
1 [0,2] diff: 3
2 [0,2] diff: 3
0 [1,8] diff: 7
1 [1,8] diff: 7
2 [1,8] diff: 7
0 [2,1] diff: 4
2 [2,1] diff: 4
0 [3,8] diff: 4
1 [4,0] diff: 4
0 [4,6] diff: 2
1 [4,6] diff: 2
2 [4,6] diff: 2
0 [5,0] diff: 6
2 [5,0] diff: 6
1 [5,4] diff: 4
2 [5,4] diff: 4
1 [7,1] diff: 6
=== Claiming: False ===
[0:1,0|0:1,1|0:1,2]=2
candy: 1, box: 0, kind 0
0:1,4: 1|2|5|9 -&gt; 2|5|9
0:1,5: 1|2|5|6 -&gt; 2|5|6
0:1,7: 1|5|6|9 -&gt; 5|6|9

[1:3,5|1:4,5|1:5,5]=2
candy: 1, box: 4, kind 1
1:0,5: 1|2|6|8 -&gt; 2|6|8
1:6,5: 1|2|5|8 -&gt; 2|5|8

[0:1,0|0:1,1|0:1,2]=2
candy: 2, box: 0, kind 0
0:1,4: 2|5|9 -&gt; 5|9
0:1,5: 2|5|6 -&gt; 5|6

[1:3,2|1:4,2|1:5,2]=2
candy: 9, box: 3, kind 1
1:7,2: 1|2|5|8|9 -&gt; 1|2|5|8
1:8,2: 2|5|8|9 -&gt; 2|5|8
=== Claiming: True ===
[1:6,0|1:7,0|1:8,0]=2
candy: 1, box: 6, kind 1
1:6,1: 1|2|5 -&gt; 2|5

[1:6,0|1:7,0|1:8,0]=2
candy: 1, box: 6, kind 1
1:7,2: 1|2|5|8 -&gt; 2|5|8
Enter1Poss: [4,0] 4
Enter1Poss: [5,0] 6
Enter1Poss: [2,1] 4
Enter1Poss: [7,1] 6
Enter1Poss: [0,2] 3
Enter1Poss: [5,4] 4
Enter1Poss: [4,6] 2
Enter1Poss: [1,8] 7
Enter1Poss: [3,8] 4
Call calculate candidates!
0 [8,3] diff: 6
1 [8,3] diff: 6
2 [8,3] diff: 6
=== Claiming: False ====== Claiming: True ===Enter1Poss: [8,3] 6
Call calculate candidates!
</act>
      <exp>=== Claiming: False ===
[1:0,5|1:1,5|1:2,5]=2
candy: 6, box: 1, kind 1
1:8,5: 2|5|6|8 -&gt; 2|5|8
=== Claiming: True ===
[1:6,8|1:7,8|1:8,8]=3
candy: 2, box: 8, kind 1
1:7,6: 2|5|8|9 -&gt; 5|8|9

[1:6,0|1:7,0|1:8,0]=2
candy: 3, box: 6, kind 1
1:7,2: 1|2|3|5|8|9 -&gt; 1|2|5|8|9
1:8,2: 2|3|5|8|9 -&gt; 2|5|8|9

[0:4,0|0:4,1|0:4,2]=2
candy: 4, box: 3, kind 0
0:5,0: 1|4|6 -&gt; 1|6

[1:3,6|1:4,6|1:5,6]=3
candy: 7, box: 5, kind 1
1:3,8: 1|4|7|8|9 -&gt; 1|4|8|9
1:5,8: 1|3|4|5|7 -&gt; 1|3|4|5
Call calculate candidates!
0 [0,2] diff: 3
1 [0,2] diff: 3
2 [0,2] diff: 3
0 [1,8] diff: 7
1 [1,8] diff: 7
2 [1,8] diff: 7
0 [2,1] diff: 4
2 [2,1] diff: 4
0 [3,8] diff: 4
1 [4,0] diff: 4
0 [4,6] diff: 2
1 [4,6] diff: 2
2 [4,6] diff: 2
0 [5,0] diff: 6
2 [5,0] diff: 6
1 [5,4] diff: 4
2 [5,4] diff: 4
1 [7,1] diff: 6
=== Claiming: False ===
[0:1,0|0:1,1|0:1,2]=2
candy: 1, box: 0, kind 0
0:1,4: 1|2|5|9 -&gt; 2|5|9
0:1,5: 1|2|5|6 -&gt; 2|5|6
0:1,7: 1|5|6|9 -&gt; 5|6|9

[1:3,5|1:4,5|1:5,5]=2
candy: 1, box: 4, kind 1
1:0,5: 1|2|6|8 -&gt; 2|6|8
1:6,5: 1|2|5|8 -&gt; 2|5|8

[0:1,0|0:1,1|0:1,2]=2
candy: 2, box: 0, kind 0
0:1,4: 2|5|9 -&gt; 5|9
0:1,5: 2|5|6 -&gt; 5|6

[1:3,2|1:4,2|1:5,2]=2
candy: 9, box: 3, kind 1
1:7,2: 1|2|5|8|9 -&gt; 1|2|5|8
1:8,2: 2|5|8|9 -&gt; 2|5|8
=== Claiming: True ===
[1:6,0|1:7,0|1:8,0]=2
candy: 1, box: 6, kind 1
1:6,1: 1|2|5 -&gt; 2|5

[1:6,0|1:7,0|1:8,0]=2
candy: 1, box: 6, kind 1
1:7,2: 1|2|5|8 -&gt; 2|5|8
Enter1Poss: [4,0] 4
Enter1Poss: [5,0] 6
Enter1Poss: [2,1] 4
Enter1Poss: [7,1] 6
Enter1Poss: [0,2] 3
Enter1Poss: [5,4] 4
Enter1Poss: [4,6] 2
Enter1Poss: [1,8] 7
Enter1Poss: [3,8] 4
Call calculate candidates!
0 [8,3] diff: 6
1 [8,3] diff: 6
2 [8,3] diff: 6
=== Claiming: False ====== Claiming: True ===Enter1Poss: [8,3] 6
Call calculate candidates!
</exp>
    </TestItem>
    <TestItem>
      <name>Test ...53..8..4.89..</name>
      <pass>true</pass>
      <act>=== Claiming: False ===
[0:8,0|0:8,1|0:8,2]=2
candy: 3, box: 6, kind 0
0:8,3: 3|4 -&gt; 4
0:8,5: 2|3|4|5 -&gt; 2|4|5

[1:3,2|1:4,2|1:5,2]=2
candy: 4, box: 3, kind 1
1:7,2: 2|4|5|6 -&gt; 2|5|6
1:8,2: 2|3|4|5|7 -&gt; 2|3|5|7

[0:6,6|0:6,7|0:6,8]=2
candy: 5, box: 8, kind 0
0:6,1: 2|5|6 -&gt; 2|6
0:6,4: 2|5|6 -&gt; 2|6
=== Claiming: True ===
[1:3,5|1:4,5|1:5,5]=2
candy: 3, box: 4, kind 1
1:5,3: 3|4|6|7|9 -&gt; 4|6|7|9

[0:7,0|0:7,1|0:7,2]=2
candy: 5, box: 6, kind 0
0:8,2: 2|3|5|7 -&gt; 2|3|7

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:0,0: 2|7 -&gt; 2
0:0,2: 2|6|7 -&gt; 2|6

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:2,2: 2|3|5|6|7|8 -&gt; 2|3|5|6|8

[1:3,8|1:4,8|1:5,8]=2
candy: 8, box: 5, kind 1
1:3,6: 1|4|5|8|9 -&gt; 1|4|5|9

[1:3,5|1:4,5|1:5,5]=3
candy: 9, box: 4, kind 1
1:4,3: 4|6|9 -&gt; 4|6
1:5,3: 4|6|7|9 -&gt; 4|6|7

[1:3,7|1:4,7|1:5,7]=3
candy: 9, box: 5, kind 1
1:3,6: 1|4|5|9 -&gt; 1|4|5
Call calculate candidates!
RED -&gt; [0,0] calc: 2
1 [0,1] diff: 1
2 [0,1] diff: 1
0 [0,6] diff: 9
1 [0,6] diff: 9
2 [0,6] diff: 9
0 [0,8] diff: 7
RED -&gt; [1,6] calc: 1
0 [2,2] diff: 8
1 [2,2] diff: 8
2 [2,2] diff: 8
2 [2,4] diff: 7
RED -&gt; [2,6] calc: 4
RED -&gt; [3,2] calc: 4
0 [4,2] diff: 2
2 [4,2] diff: 2
RED -&gt; [5,1] calc: 9
1 [5,3] diff: 7
0 [6,3] diff: 3
1 [6,3] diff: 3
2 [6,3] diff: 3
0 [6,6] diff: 8
1 [6,6] diff: 8
2 [6,6] diff: 8
0 [6,7] diff: 5
2 [6,7] diff: 5
1 [7,2] diff: 5
0 [7,3] diff: 9
1 [7,3] diff: 9
2 [7,3] diff: 9
RED -&gt; [7,8] calc: 2
RED -&gt; [8,3] calc: 4
=== Claiming: False ===
[1:0,5|1:1,5|1:2,5]=3
candy: 2, box: 1, kind 1
1:8,5: 2|4|5 -&gt; 4|5

[0:1,0|0:1,1|0:1,2]=2
candy: 3, box: 0, kind 0
0:1,7: 2|3|6 -&gt; 2|6

[1:0,5|1:1,5|1:2,5]=2
candy: 4, box: 1, kind 1
1:3,5: 1|3|4|5|9 -&gt; 1|3|5|9
1:4,5: 1|4|5|6|9 -&gt; 1|5|6|9
1:5,5: 3|4|6|9 -&gt; 3|6|9
1:8,5: 4|5 -&gt; 5

[0:2,6|0:2,7|0:2,8]=2
candy: 4, box: 2, kind 0
0:2,5: 2|4|6 -&gt; 2|6

[0:8,3|0:8,4|0:8,5]=2
candy: 4, box: 7, kind 0
0:8,0: 2|3|4|7 -&gt; 2|3|7

[1:0,5|1:1,5|1:2,5]=3
candy: 6, box: 1, kind 1
1:4,5: 1|5|6|9 -&gt; 1|5|9
1:5,5: 3|6|9 -&gt; 3|9

[1:6,1|1:7,1|1:8,1]=2
candy: 6, box: 6, kind 1
1:2,1: 2|5|6 -&gt; 2|5
=== Claiming: True ===
[1:3,8|1:4,8|1:5,8]=2
candy: 1, box: 5, kind 1
1:3,6: 1|4|5 -&gt; 4|5

[1:0,7|1:1,7|1:2,7]=2
candy: 2, box: 2, kind 1
1:2,8: 2|3|6|7 -&gt; 3|6|7
Enter1Poss: [0,0] 2
Enter1Poss: [0,1] 1
Enter1Poss: [5,1] 9
Enter1Poss: [2,2] 8
Enter1Poss: [3,2] 4
Enter1Poss: [4,2] 2
Enter1Poss: [7,2] 5
Enter1Poss: [5,3] 7
Enter1Poss: [6,3] 3
Enter1Poss: [7,3] 9
Enter1Poss: [8,3] 4
Enter1Poss: [2,4] 7
Enter1Poss: [8,5] 5
Enter1Poss: [0,6] 9
Enter1Poss: [1,6] 1
Enter1Poss: [2,6] 4
Enter1Poss: [6,6] 8
Enter1Poss: [6,7] 5
Enter1Poss: [0,8] 7
Enter1Poss: [7,8] 2
Call calculate candidates!
RED -&gt; [0,2] calc: 6
0 [0,5] diff: 4
1 [0,5] diff: 4
2 [0,5] diff: 4
RED -&gt; [2,1] calc: 5
RED -&gt; [3,6] calc: 5
RED -&gt; [4,3] calc: 6
0 [4,4] diff: 5
0 [4,7] diff: 4
1 [5,4] diff: 4
2 [5,4] diff: 4
RED -&gt; [5,5] calc: 3
0 [5,8] diff: 8
1 [6,1] diff: 2
2 [6,1] diff: 2
0 [6,4] diff: 6
1 [6,4] diff: 6
2 [6,4] diff: 6
RED -&gt; [7,0] calc: 4
RED -&gt; [7,1] calc: 6
RED -&gt; [8,4] calc: 2
=== Claiming: False ====== Claiming: True ===Enter1Poss: [7,0] 4
Enter1Poss: [2,1] 5
Enter1Poss: [6,1] 2
Enter1Poss: [7,1] 6
Enter1Poss: [0,2] 6
Enter1Poss: [4,3] 6
Enter1Poss: [4,4] 5
Enter1Poss: [5,4] 4
Enter1Poss: [6,4] 6
Enter1Poss: [8,4] 2
Enter1Poss: [0,5] 4
Enter1Poss: [5,5] 3
Enter1Poss: [3,6] 5
Enter1Poss: [4,7] 4
Enter1Poss: [5,8] 8
Call calculate candidates!
1 [2,8] diff: 6
RED -&gt; [3,4] calc: 8
1 [3,7] diff: 9
2 [3,7] diff: 9
0 [3,8] diff: 3
1 [3,8] diff: 3
2 [3,8] diff: 3
0 [4,5] diff: 9
RED -&gt; [4,8] calc: 1
RED -&gt; [5,7] calc: 6
=== Claiming: False ====== Claiming: True ===Enter1Poss: [3,4] 8
Enter1Poss: [4,5] 9
Enter1Poss: [3,7] 9
Enter1Poss: [5,7] 6
Enter1Poss: [2,8] 6
Enter1Poss: [3,8] 3
Enter1Poss: [4,8] 1
Call calculate candidates!
0 [1,5] diff: 6
1 [1,5] diff: 6
2 [1,5] diff: 6
RED -&gt; [1,7] calc: 2
RED -&gt; [2,5] calc: 2
0 [2,7] diff: 3
1 [2,7] diff: 3
2 [2,7] diff: 3
RED -&gt; [3,5] calc: 1
=== Claiming: False ====== Claiming: True ===Enter1Poss: [1,5] 6
Enter1Poss: [2,5] 2
Enter1Poss: [3,5] 1
Enter1Poss: [1,7] 2
Enter1Poss: [2,7] 3
Call calculate candidates!
</act>
      <exp>=== Claiming: False ===
[0:8,0|0:8,1|0:8,2]=2
candy: 3, box: 6, kind 0
0:8,3: 3|4 -&gt; 4
0:8,5: 2|3|4|5 -&gt; 2|4|5

[1:3,2|1:4,2|1:5,2]=2
candy: 4, box: 3, kind 1
1:7,2: 2|4|5|6 -&gt; 2|5|6
1:8,2: 2|3|4|5|7 -&gt; 2|3|5|7

[0:6,6|0:6,7|0:6,8]=2
candy: 5, box: 8, kind 0
0:6,1: 2|5|6 -&gt; 2|6
0:6,4: 2|5|6 -&gt; 2|6
=== Claiming: True ===
[1:3,5|1:4,5|1:5,5]=2
candy: 3, box: 4, kind 1
1:5,3: 3|4|6|7|9 -&gt; 4|6|7|9

[0:7,0|0:7,1|0:7,2]=2
candy: 5, box: 6, kind 0
0:8,2: 2|3|5|7 -&gt; 2|3|7

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:0,0: 2|7 -&gt; 2
0:0,2: 2|6|7 -&gt; 2|6

[0:1,0|0:1,1|0:1,2]=2
candy: 7, box: 0, kind 0
0:2,2: 2|3|5|6|7|8 -&gt; 2|3|5|6|8

[1:3,8|1:4,8|1:5,8]=2
candy: 8, box: 5, kind 1
1:3,6: 1|4|5|8|9 -&gt; 1|4|5|9

[1:3,5|1:4,5|1:5,5]=3
candy: 9, box: 4, kind 1
1:4,3: 4|6|9 -&gt; 4|6
1:5,3: 4|6|7|9 -&gt; 4|6|7

[1:3,7|1:4,7|1:5,7]=3
candy: 9, box: 5, kind 1
1:3,6: 1|4|5|9 -&gt; 1|4|5
Call calculate candidates!
RED -&gt; [0,0] calc: 2
1 [0,1] diff: 1
2 [0,1] diff: 1
0 [0,6] diff: 9
1 [0,6] diff: 9
2 [0,6] diff: 9
0 [0,8] diff: 7
RED -&gt; [1,6] calc: 1
0 [2,2] diff: 8
1 [2,2] diff: 8
2 [2,2] diff: 8
2 [2,4] diff: 7
RED -&gt; [2,6] calc: 4
RED -&gt; [3,2] calc: 4
0 [4,2] diff: 2
2 [4,2] diff: 2
RED -&gt; [5,1] calc: 9
1 [5,3] diff: 7
0 [6,3] diff: 3
1 [6,3] diff: 3
2 [6,3] diff: 3
0 [6,6] diff: 8
1 [6,6] diff: 8
2 [6,6] diff: 8
0 [6,7] diff: 5
2 [6,7] diff: 5
1 [7,2] diff: 5
0 [7,3] diff: 9
1 [7,3] diff: 9
2 [7,3] diff: 9
RED -&gt; [7,8] calc: 2
RED -&gt; [8,3] calc: 4
=== Claiming: False ===
[1:0,5|1:1,5|1:2,5]=3
candy: 2, box: 1, kind 1
1:8,5: 2|4|5 -&gt; 4|5

[0:1,0|0:1,1|0:1,2]=2
candy: 3, box: 0, kind 0
0:1,7: 2|3|6 -&gt; 2|6

[1:0,5|1:1,5|1:2,5]=2
candy: 4, box: 1, kind 1
1:3,5: 1|3|4|5|9 -&gt; 1|3|5|9
1:4,5: 1|4|5|6|9 -&gt; 1|5|6|9
1:5,5: 3|4|6|9 -&gt; 3|6|9
1:8,5: 4|5 -&gt; 5

[0:2,6|0:2,7|0:2,8]=2
candy: 4, box: 2, kind 0
0:2,5: 2|4|6 -&gt; 2|6

[0:8,3|0:8,4|0:8,5]=2
candy: 4, box: 7, kind 0
0:8,0: 2|3|4|7 -&gt; 2|3|7

[1:0,5|1:1,5|1:2,5]=3
candy: 6, box: 1, kind 1
1:4,5: 1|5|6|9 -&gt; 1|5|9
1:5,5: 3|6|9 -&gt; 3|9

[1:6,1|1:7,1|1:8,1]=2
candy: 6, box: 6, kind 1
1:2,1: 2|5|6 -&gt; 2|5
=== Claiming: True ===
[1:3,8|1:4,8|1:5,8]=2
candy: 1, box: 5, kind 1
1:3,6: 1|4|5 -&gt; 4|5

[1:0,7|1:1,7|1:2,7]=2
candy: 2, box: 2, kind 1
1:2,8: 2|3|6|7 -&gt; 3|6|7
Enter1Poss: [0,0] 2
Enter1Poss: [0,1] 1
Enter1Poss: [5,1] 9
Enter1Poss: [2,2] 8
Enter1Poss: [3,2] 4
Enter1Poss: [4,2] 2
Enter1Poss: [7,2] 5
Enter1Poss: [5,3] 7
Enter1Poss: [6,3] 3
Enter1Poss: [7,3] 9
Enter1Poss: [8,3] 4
Enter1Poss: [2,4] 7
Enter1Poss: [8,5] 5
Enter1Poss: [0,6] 9
Enter1Poss: [1,6] 1
Enter1Poss: [2,6] 4
Enter1Poss: [6,6] 8
Enter1Poss: [6,7] 5
Enter1Poss: [0,8] 7
Enter1Poss: [7,8] 2
Call calculate candidates!
RED -&gt; [0,2] calc: 6
0 [0,5] diff: 4
1 [0,5] diff: 4
2 [0,5] diff: 4
RED -&gt; [2,1] calc: 5
RED -&gt; [3,6] calc: 5
RED -&gt; [4,3] calc: 6
0 [4,4] diff: 5
0 [4,7] diff: 4
1 [5,4] diff: 4
2 [5,4] diff: 4
RED -&gt; [5,5] calc: 3
0 [5,8] diff: 8
1 [6,1] diff: 2
2 [6,1] diff: 2
0 [6,4] diff: 6
1 [6,4] diff: 6
2 [6,4] diff: 6
RED -&gt; [7,0] calc: 4
RED -&gt; [7,1] calc: 6
RED -&gt; [8,4] calc: 2
=== Claiming: False ====== Claiming: True ===Enter1Poss: [7,0] 4
Enter1Poss: [2,1] 5
Enter1Poss: [6,1] 2
Enter1Poss: [7,1] 6
Enter1Poss: [0,2] 6
Enter1Poss: [4,3] 6
Enter1Poss: [4,4] 5
Enter1Poss: [5,4] 4
Enter1Poss: [6,4] 6
Enter1Poss: [8,4] 2
Enter1Poss: [0,5] 4
Enter1Poss: [5,5] 3
Enter1Poss: [3,6] 5
Enter1Poss: [4,7] 4
Enter1Poss: [5,8] 8
Call calculate candidates!
1 [2,8] diff: 6
RED -&gt; [3,4] calc: 8
1 [3,7] diff: 9
2 [3,7] diff: 9
0 [3,8] diff: 3
1 [3,8] diff: 3
2 [3,8] diff: 3
0 [4,5] diff: 9
RED -&gt; [4,8] calc: 1
RED -&gt; [5,7] calc: 6
=== Claiming: False ====== Claiming: True ===Enter1Poss: [3,4] 8
Enter1Poss: [4,5] 9
Enter1Poss: [3,7] 9
Enter1Poss: [5,7] 6
Enter1Poss: [2,8] 6
Enter1Poss: [3,8] 3
Enter1Poss: [4,8] 1
Call calculate candidates!
0 [1,5] diff: 6
1 [1,5] diff: 6
2 [1,5] diff: 6
RED -&gt; [1,7] calc: 2
RED -&gt; [2,5] calc: 2
0 [2,7] diff: 3
1 [2,7] diff: 3
2 [2,7] diff: 3
RED -&gt; [3,5] calc: 1
=== Claiming: False ====== Claiming: True ===Enter1Poss: [1,5] 6
Enter1Poss: [2,5] 2
Enter1Poss: [3,5] 1
Enter1Poss: [1,7] 2
Enter1Poss: [2,7] 3
Call calculate candidates!
</exp>
    </TestItem>
    <TestItem>
      <name>Test .4...9368..648..</name>
      <pass>true</pass>
      <act>=== Claiming: False ===
[1:6,6|1:7,6|1:8,6]=3
candy: 2, box: 8, kind 1
1:3,6: 2|5|6|7|9 -&gt; 5|6|7|9
1:4,6: 1|2|5|6|7 -&gt; 1|5|6|7

[0:4,3|0:4,4|0:4,5]=2
candy: 5, box: 4, kind 0
0:4,1: 1|2|5|6|7|8 -&gt; 1|2|6|7|8
0:4,6: 1|5|6|7 -&gt; 1|6|7
0:4,8: 1|5|6 -&gt; 1|6

[0:1,6|0:1,7|0:1,8]=2
candy: 7, box: 2, kind 0
0:1,0: 1|2|3|7 -&gt; 1|2|3
0:1,1: 1|2|3|7 -&gt; 1|2|3
=== Claiming: True ===
[0:8,0|0:8,1|0:8,2]=3
candy: 3, box: 6, kind 0
0:6,1: 1|2|3|6|7 -&gt; 1|2|6|7

[0:8,0|0:8,1|0:8,2]=3
candy: 3, box: 6, kind 0
0:7,0: 1|2|3|6|7|8 -&gt; 1|2|6|7|8
0:7,1: 1|2|3|6|7|8 -&gt; 1|2|6|7|8
Call calculate candidates!
</act>
      <exp>=== Claiming: False ===
[1:6,6|1:7,6|1:8,6]=3
candy: 2, box: 8, kind 1
1:3,6: 2|5|6|7|9 -&gt; 5|6|7|9
1:4,6: 1|2|5|6|7 -&gt; 1|5|6|7

[0:4,3|0:4,4|0:4,5]=2
candy: 5, box: 4, kind 0
0:4,1: 1|2|5|6|7|8 -&gt; 1|2|6|7|8
0:4,6: 1|5|6|7 -&gt; 1|6|7
0:4,8: 1|5|6 -&gt; 1|6

[0:1,6|0:1,7|0:1,8]=2
candy: 7, box: 2, kind 0
0:1,0: 1|2|3|7 -&gt; 1|2|3
0:1,1: 1|2|3|7 -&gt; 1|2|3
=== Claiming: True ===
[0:8,0|0:8,1|0:8,2]=3
candy: 3, box: 6, kind 0
0:6,1: 1|2|3|6|7 -&gt; 1|2|6|7

[0:8,0|0:8,1|0:8,2]=3
candy: 3, box: 6, kind 0
0:7,0: 1|2|3|6|7|8 -&gt; 1|2|6|7|8
0:7,1: 1|2|3|6|7|8 -&gt; 1|2|6|7|8
Call calculate candidates!
</exp>
    </TestItem>
    <TestItem>
      <name>Test 6...415....9.834</name>
      <pass>true</pass>
      <act>=== Claiming: False ====== Claiming: True ===Call calculate candidates!
1 [3,1] diff: 6
2 [3,1] diff: 6
0 [5,8] diff: 5
1 [5,8] diff: 5
2 [5,8] diff: 5
=== Claiming: False ====== Claiming: True ===Enter1Poss: [3,1] 6
Enter1Poss: [5,8] 5
Call calculate candidates!
RED -&gt; [3,7] calc: 2
=== Claiming: False ====== Claiming: True ===Enter1Poss: [3,7] 2
Call calculate candidates!
RED -&gt; [0,7] calc: 9
=== Claiming: False ====== Claiming: True ===Enter1Poss: [0,7] 9
Call calculate candidates!
</act>
      <exp>=== Claiming: False ====== Claiming: True ===Call calculate candidates!
1 [3,1] diff: 6
2 [3,1] diff: 6
0 [5,8] diff: 5
1 [5,8] diff: 5
2 [5,8] diff: 5
=== Claiming: False ====== Claiming: True ===Enter1Poss: [3,1] 6
Enter1Poss: [5,8] 5
Call calculate candidates!
RED -&gt; [3,7] calc: 2
=== Claiming: False ====== Claiming: True ===Enter1Poss: [3,7] 2
Call calculate candidates!
RED -&gt; [0,7] calc: 9
=== Claiming: False ====== Claiming: True ===Enter1Poss: [0,7] 9
Call calculate candidates!
</exp>
    </TestItem>
    <TestItem>
      <name>Test ....38.5..8...59</name>
      <pass>true</pass>
      <act>=== Claiming: False ===
[1:3,1|1:4,1|1:5,1]=2
candy: 3, box: 3, kind 1
1:2,1: 3|5|9 -&gt; 5|9
1:6,1: 3|5|6 -&gt; 5|6
1:7,1: 3|5|6|7|9 -&gt; 5|6|7|9

[1:0,3|1:1,3|1:2,3]=2
candy: 9, box: 1, kind 1
1:4,3: 2|4|8|9 -&gt; 2|4|8
=== Claiming: True ===Call calculate candidates!
0 [4,3] diff: 8
1 [4,3] diff: 8
2 [4,3] diff: 8
RED -&gt; [6,2] calc: 3
0 [8,0] diff: 8
1 [8,0] diff: 8
2 [8,0] diff: 8
0 [8,2] diff: 1
2 [8,2] diff: 1
=== Claiming: False ====== Claiming: True ===Enter1Poss: [8,0] 8
Enter1Poss: [6,2] 3
Enter1Poss: [8,2] 1
Enter1Poss: [4,3] 8
Call calculate candidates!
RED -&gt; [6,0] calc: 5
=== Claiming: False ====== Claiming: True ===Enter1Poss: [6,0] 5
Call calculate candidates!
0 [2,1] diff: 5
1 [2,1] diff: 5
2 [2,1] diff: 5
RED -&gt; [6,1] calc: 6
=== Claiming: False ====== Claiming: True ===Enter1Poss: [2,1] 5
Enter1Poss: [6,1] 6
Call calculate candidates!
</act>
      <exp>=== Claiming: False ===
[1:3,1|1:4,1|1:5,1]=2
candy: 3, box: 3, kind 1
1:2,1: 3|5|9 -&gt; 5|9
1:6,1: 3|5|6 -&gt; 5|6
1:7,1: 3|5|6|7|9 -&gt; 5|6|7|9

[1:0,3|1:1,3|1:2,3]=2
candy: 9, box: 1, kind 1
1:4,3: 2|4|8|9 -&gt; 2|4|8
=== Claiming: True ===Call calculate candidates!
0 [4,3] diff: 8
1 [4,3] diff: 8
2 [4,3] diff: 8
RED -&gt; [6,2] calc: 3
0 [8,0] diff: 8
1 [8,0] diff: 8
2 [8,0] diff: 8
0 [8,2] diff: 1
2 [8,2] diff: 1
=== Claiming: False ====== Claiming: True ===Enter1Poss: [8,0] 8
Enter1Poss: [6,2] 3
Enter1Poss: [8,2] 1
Enter1Poss: [4,3] 8
Call calculate candidates!
RED -&gt; [6,0] calc: 5
=== Claiming: False ====== Claiming: True ===Enter1Poss: [6,0] 5
Call calculate candidates!
0 [2,1] diff: 5
1 [2,1] diff: 5
2 [2,1] diff: 5
RED -&gt; [6,1] calc: 6
=== Claiming: False ====== Claiming: True ===Enter1Poss: [2,1] 5
Enter1Poss: [6,1] 6
Call calculate candidates!
</exp>
    </TestItem>
  </GroupItem>
</Tests>