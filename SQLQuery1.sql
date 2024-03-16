--Kiểm tra ràng buộc
EXEC sp_helpconstraint 'orders_table';
--Xoá ràng buộc
ALTER TABLE assignment
DROP CONSTRAINT FK_order ;

ALTER TABLE orders_table 
DROP CONSTRAINT (constraint_name :lấy ở câu lệnh 1 ) ;

-- Xóa trường cũ
ALTER TABLE orders_table
DROP COLUMN order_id;
-- Thêm trường mới với kiểu tự động tăng
ALTER TABLE orders_table
ADD order_id INT IDENTITY(1,1) PRIMARY KEY;

--thêm khoá

ALTER TABLE assignment
ADD CONSTRAINT FK_order
FOREIGN KEY (order_id) REFERENCES orders_table(order_id);

