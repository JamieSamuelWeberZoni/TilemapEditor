-- Project		: Tilemap Editor
-- Description	: A C# program where you can modify and create tilesets and tilemaps with an access to a database
-- File			: 01-Database.sql
-- Author		: Weber Jamie
-- Date			: 06 October 2023

CREATE DATABASE IF NOT EXISTS TilemapEditor;
USE TilemapEditor;

-- --------------------------------------------------------------
-- Tables
-- --------------------------------------------------------------

CREATE TABLE IF NOT EXISTS Tilesets (
	idTileset INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS Tiles (
	idTile INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    image LONGBLOB NOT NULL,
    number INT NOT NULL,
    idTileset INT NOT NULL
);

CREATE TABLE IF NOT EXISTS Tilemaps (
	idTilemap INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    name VARCHAR(50) NOT NULL,
    idTileset INT NOT NULL
);

CREATE TABLE IF NOT EXISTS TilesPosition(
	idTilemap INT NOT NULL,
    posX INT NOT NULL,
    posY INT NOT NULL,
    number INT NOT NULL,
    PRIMARY KEY(idTilemap, posX, posY)
);

-- --------------------------------------------------------------
-- Constraints
-- --------------------------------------------------------------

ALTER TABLE Tiles
ADD CONSTRAINT fk_tiles_tilesets
FOREIGN KEY (idTileset)
REFERENCES Tilesets(idTileset);

ALTER TABLE Tilemaps
ADD CONSTRAINT fk_tilemaps_tilesets
FOREIGN KEY (idTileset)
REFERENCES Tilesets(idTileset);

ALTER TABLE TilesPosition
ADD CONSTRAINT fk_tilesposition_tilemaps
FOREIGN KEY (idTilemap)
REFERENCES Tilemaps(idTilemap);