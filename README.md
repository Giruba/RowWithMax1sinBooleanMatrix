#Author : Giruba Beulah SE

# RowWithMax1sinBooleanMatrix
C# program to find the row that has the maximum number of 1s in a boolean matrix

Given a boolean sorted matrix, find the row that has the highest number of 1s.

Logic:
    1. Find the index of the First Occurence of 1 in First row 
    (Although Binary Search can be used, here I have used just iterating over and breaking when match is found!)
    
    2. If there is no 1 in the first row, initialize the index to be the last column.
    
    3. For the rest of the rows, check whether matrix[i, index] is a 1 
       Subtract the index further until a 0 is encountered.
       
       Calculate the maimum number of ones by subracting the index from the No of Columns
       
       Compare with the maxCount so far and set the MaxCount
       
     4. Print the MaxCount
     
     
     Example:
     0 0 0
     0 0 1
     0 1 1
     
     No ones in first row ---> So Index = 3-1 [Total No of Columns -1 (array Index denoting the last entry)]
                                  Index = 2
                                  
                                  First row : matrix[1,2] is 1
                                              Index = Index -1 -> 1
                                              But matrix[1, 1] is 0
                                              
                                              So max Ones so far is : 2 - 1 => 1
                                  Second row: matrix[2,1] is 1
                                              Index becomes 0
                                              But matrix[2,0] is 0
                                              
                                              But maxOnes so far is: 2 - 0 -> 2
                                              
                                              Max Ones So Far: (No of Columns - 1 - Index)
                                              
                                  
       
    
