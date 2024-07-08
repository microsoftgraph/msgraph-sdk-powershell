### Example 1: Get assignments with delta query support

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentDelta -EducationClassId $educationClassId -Top 2 

```
This example will get assignments with delta query support

### Example 2: Get next set of assignments with delta query support

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentDelta -EducationClassId $educationClassId -Skiptoken "U43TyYWKlRvJ6wWxZOfJvkp22nMqShRw9f-GxBtG2FDy9b1hMDaAJGdLb7n2fh1IdHoweKQs1czM4Ry1LVsNqwIFXftTcRHvgSCbcszvbJHEWDCO3QO7K7zwCM8DdXNepZOa1gqldecjIUM0NFRbGQoQ5yR6RmGnMgtko8TDMOyMH_yg1my82PTXA_t4Nj-DhMDZWvuNTd_lbLeTngc7mIJPMCR2gHN9CSKsW_kw850.UM9tUqwOu5Ln1pnxaP6KdMmfJHszGqY3EKPlQkOiyGs" 

```
This example will get next set of assignments with delta query support

### Example 3: Get the created and modified assignments using delta token

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentDelta -EducationClassId $educationClassId -Deltatoken "7ORzTfzlUEGDy6BRE3OC-3ePBbvLHCRe4aJ_hjaBKJxUHmn_ODgoM4xreLS7YRaxROmLjac48n-iXm5j6n5aQwlsnC-2OvL3lI0Z8M4klERNmJQjnBn7MHqwXZ6L8GlI3VPnya3E-p1bisiZX97jLvQUAopseIYhvnD6v7fiYrk.fVsHempT6X2CiBh6aN9Ex5nVJ71adKdcf-mdke8OHKs" 

```
This example will get the created and modified assignments using delta token

### Example 4: Using `$select` to get selected data

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentDelta -EducationClassId $educationClassId -Property "displayName,id" 

```
This example shows using `$select` to get selected data

