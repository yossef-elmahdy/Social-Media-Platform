TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER `log_insert_users` AFTER INSERT ON `users` FOR EACH ROW BEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (1, \'INSERT\', \'users\', CONCAT(\'a new row is inserted in users table called: \', NEW.username), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER `log_update_users` AFTER UPDATE ON `users` FOR EACH ROW BEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (2, \'UPDATE\', \'users\', CONCAT(\'a row is updated in users table called: \', NEW.username), CURRENT_TIMESTAMP);\nEND' 'CREATE DEFINER=`root`@`localhost` TRIGGER `log_delete_users` BEFORE DELETE ON `users` FOR EACH ROW BEGIN\n	INSERT INTO logging(log_type_id, log_type, on_table, log_context, log_time) VALUES (3, \'DELETE\', \'users\', CONCAT(\'a row is deleted in users table called: \', OLD.username), CURRENT_TIMESTAMP);\nEND'
sql_modes=1098907648 1098907648 1098907648
definers='root@localhost' 'root@localhost' 'root@localhost'
client_cs_names='utf8mb4' 'utf8mb4' 'utf8mb4'
connection_cl_names='utf8mb4_unicode_ci' 'utf8mb4_unicode_ci' 'utf8mb4_unicode_ci'
db_cl_names='utf8mb4_general_ci' 'utf8mb4_general_ci' 'utf8mb4_general_ci'
created=162315607095 162315608166 162315606210
