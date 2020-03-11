-- Given a payment table, which is a part of DVD Rental Sample Database, with the following schema

-- Column       | Type                        | Modifiers
-- -------------+-----------------------------+----------
-- payment_id   | integer                     | not null 
-- customer_id  | smallint                    | not null
-- staff_id     | smallint                    | not null
-- rental_id    | integer                     | not null
-- amount       | numeric(5,2)                | not null
-- payment_date | timestamp without time zone | not null

-- produce a result set for the report that shows a side-by-side comparison of the number and total amounts of payments made in Mike's and Jon's stores broken down by months.

-- The resulting data set should be ordered by month using natural order (Jan, Feb, Mar, etc.).

-- Note: You don't need to worry about the year component. Months are never repeated because the sample data set contains payment information only for one year.

    -- month - number of the month (1 - January, 2 - February, etc.)
    -- total_count - total number of payments
    -- total_amount - total payment amount
    -- mike_count - total number of payments accepted by Mike (staff_id = 1)
    -- mike_amount - total amount of payments accepted by Mike (staff_id = 1)
    -- jon_count - total number of payments accepted by Jon (staff_id = 2)
    -- jon_amount - total amount of payments accepted by Jon (staff_id = 2)

select EXTRACT(MONTH FROM payment_date) as "month",
COUNT(staff_id) as "total_count",
SUM(amount) as "total_amount",
COUNT(case when staff_id ='1' then 1 else null end ) as "mike_count",
sum(case when staff_id ='1' then amount else null end ) as "mike_amount",
COUNT(case when staff_id ='2' then 1 else null end ) as "jon_count",
sum(case when staff_id ='2' then amount else null end ) as "jon_amount"
from payment
GROUP BY EXTRACT(MONTH FROM payment_date)
ORDER BY EXTRACT(MONTH FROM payment_date)