TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER log_insert_genders AFTER INSERT ON genders FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (1, \'INSERT\', \'genders\', CONCAT(\'a new row is inserted in genders table called: \', NEW.name), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER log_update_genders AFTER UPDATE ON genders FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (2, \'UPDATE\', \'genders\', CONCAT(\'a row is updated in genders table called: \', NEW.name), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER log_delete_genders BEFORE DELETE ON genders FOR EACH ROW \nBEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (3, \'DELETE\', \'genders\', CONCAT(\'a row is deleted in genders table called: \', OLD.name), CURRENT_TIMESTAMP);\nEND'
sql_modes=1098907648 1098907648 1098907648
definers='root@localhost' 'root@localhost' 'root@localhost'
client_cs_names='utf8mb4' 'utf8mb4' 'utf8mb4'
connection_cl_names='utf8mb4_unicode_ci' 'utf8mb4_unicode_ci' 'utf8mb4_unicode_ci'
db_cl_names='utf8mb4_general_ci' 'utf8mb4_general_ci' 'utf8mb4_general_ci'
created=162315627561 162315635443 162315648450
