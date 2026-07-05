# Advanced SQL Exercises for Online Retail Store

## Objective
The objective of this experiment is to learn and implement advanced SQL concepts used in database management and reporting. These exercises demonstrate ranking functions, window functions, grouping operations, Common Table Expressions (CTEs), MERGE statements, PIVOT, and UNPIVOT operations using Microsoft SQL Server.

---

## Software Used

- Microsoft SQL Server 2025
- SQL Server Management Studio (SSMS)

---

## Exercises Performed

### Exercise 1 – Ranking and Window Functions
- Used `ROW_NUMBER()`
- Used `RANK()`
- Used `DENSE_RANK()`
- Used `OVER()`
- Used `PARTITION BY`
- Displayed the top 3 most expensive products in each category.

---

### Exercise 2 – GROUPING SETS, ROLLUP and CUBE
- Joined Customers, Orders, OrderDetails, and Products tables.
- Generated reports using:
  - GROUPING SETS
  - ROLLUP
  - CUBE
- Calculated total quantity sold by Region and Category.

---

### Exercise 3 – CTEs and MERGE
- Created a Recursive CTE to generate dates.
- Created a StagingProducts table.
- Used the MERGE statement to update existing records and insert new records.

---

### Exercise 4 – PIVOT and UNPIVOT
- Aggregated monthly sales.
- Converted rows into columns using PIVOT.
- Converted columns back into rows using UNPIVOT.

---

### Exercise 5 – Common Table Expression (CTE)
- Created a CTE to count customer orders.
- Retrieved customers who placed more than three orders.

---

## Concepts Covered

- Window Functions
- ROW_NUMBER()
- RANK()
- DENSE_RANK()
- OVER Clause
- PARTITION BY
- GROUPING SETS
- ROLLUP
- CUBE
- Common Table Expressions (CTEs)
- Recursive CTE
- MERGE Statement
- PIVOT
- UNPIVOT

---

## Expected Output

- Display ranked products within each category.
- Generate sales reports with subtotals and grand totals.
- Generate calendar dates using Recursive CTE.
- Update or insert product records using MERGE.
- Display monthly sales in pivoted and unpivoted formats.
- Display customers who placed more than three orders.

---

## Result

Successfully implemented Advanced SQL concepts including Window Functions, GROUPING SETS, ROLLUP, CUBE, CTEs, MERGE, PIVOT, and UNPIVOT using Microsoft SQL Server and verified the outputs.
