ALTER TABLE dbo.orders_table ADD CONSTRAINT order_assignment FOREIGN KEY (order_id) REFERENCES dbo.assignment(order_id, shipper_id)

ALTER TABLE dbo.shipper_table ADD CONSTRAINT shipper_assignment FOREIGN KEY (shipper_id) REFERENCES dbo.assignment(shipper_id)

SELECT * FROM dbo.orders_table

DELETE FROM dbo.assignment

ALTER TABLE dbo.assignment	
ADD CONSTRAINT PK_Assignment PRIMARY KEY (order_id, shipper_id)

ALTER TABLE dbo.assignment
DROP CONSTRAINT order_assignment

ALTER TABLE dbo.assignment
DROP CONSTRAINT UC_order_id

ALTER TABLE dbo.shipper_table
ADD CONSTRAINT PK_shipper PRIMARY KEY (shipper_id)

ALTER TABLE dbo.orders_table
ADD CONSTRAINT PK_orders_table PRIMARY KEY (or);

SELECT *
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'assignment'

SELECT orders_table.order_id, total_shipping_cost, weight, distance, adress, customer_name, phone_number
FROM assignment, orders_table 
WHERE assignment.order_id = orders_table.order_id and shipper_id=1

ALTER TABLE assignment
ADD CONSTRAINT UC_order_id UNIQUE (order_id);

SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE 
    TABLE_NAME = 'orders_table' AND 
    COLUMN_NAME = 'order_id';
