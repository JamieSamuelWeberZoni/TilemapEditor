-- Project		: Tilemap Editor
-- Description	: A C# program where you can modify and create tilesets and tilemaps with an access to a database
-- File			: 02-Users.sql
-- Author		: Weber Jamie
-- Date			: 06 October 2023

DROP USER IF EXISTS 'dbTilemapEditor'@'localhost';

CREATE USER 'dbTilemapEditor'@'localhost' IDENTIFIED BY 'tilePassword';

GRANT SELECT ON TilemapEditor.* TO 'dbTilemapEditor'@'localhost';
GRANT INSERT ON TilemapEditor.* TO 'dbTilemapEditor'@'localhost';
GRANT UPDATE ON TilemapEditor.* TO 'dbTilemapEditor'@'localhost';
GRANT DELETE ON TilemapEditor.* TO 'dbTilemapEditor'@'localhost';