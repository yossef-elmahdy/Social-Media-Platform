TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER log_insert_likes AFTER INSERT ON likes FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (1, \'INSERT\', \'likes\', CONCAT(\'a new row is inserted in likes table called: \', NEW.id), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER log_update_likes AFTER UPDATE ON likes FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (2, \'UPDATE\', \'likes\', CONCAT(\'a row is updated in likes table called: \', NEW.id), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER log_delete_likes BEFORE DELETE ON likes FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (3, \'DELETE\', \'likes\', CONCAT(\'a row is deleted in likes table called: \', OLD.id), CURRENT_TIMESTAMP);\nEND'
sql_modes=1098907648 1098907648 1098907648
definers='root@localhost' 'root@localhost' 'root@localhost'
client_cs_names='utf8mb4' 'utf8mb4' 'utf8mb4'
connection_cl_names='utf8mb4_unicode_ci' 'utf8mb4_unicode_ci' 'utf8mb4_unicode_ci'
db_cl_names='utf8mb4_general_ci' 'utf8mb4_general_ci' 'utf8mb4_general_ci'
created=162315820433 162315825374 162315843236
