<?xml version="1.0" encoding="utf-8"?>
<Tests>
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
    <act>
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
    <exp>
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
    <act>
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
    <exp>
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
    <act>
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
    <exp>
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
</Tests>