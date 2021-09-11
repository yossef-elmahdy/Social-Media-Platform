TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER log_insert_comments AFTER INSERT ON comments FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (1, \'INSERT\', \'comments\', CONCAT(\'a new row is inserted in likes table called: \', NEW.id), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER log_update_comments AFTER UPDATE ON comments FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (2, \'UPDATE\', \'comments\', CONCAT(\'a new row is updated in comments table called: \', NEW.id), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER log_delete_comments BEFORE DELETE ON comments FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (3, \'DELETE\', \'comments\', CONCAT(\'a new row is deleted in comments table called: \', OLD.id), CURRENT_TIMESTAMP);\nEND'
sql_modes=1098907648 1098907648 1098907648
definers='root@localhost' 'root@localhost' 'root@localhost'
client_cs_names='utf8mb4' 'utf8mb4' 'utf8mb4'
connection_cl_names='utf8mb4_unicode_ci' 'utf8mb4_unicode_ci' 'utf8mb4_unicode_ci'
db_cl_names='utf8mb4_general_ci' 'utf8mb4_general_ci' 'utf8mb4_general_ci'
created=162315907007 162315926869 162315961693
