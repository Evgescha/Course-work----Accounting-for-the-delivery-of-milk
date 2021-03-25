DROP DATABASE IF EXISTS `milkDatabase`;
CREATE DATABASE IF NOT EXISTS `milkDatabase`;
USE `milkDatabase`;

CREATE TABLE `Экологический класс` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Класс` VARCHAR(60),  
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

CREATE TABLE `Базовое шасси` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Шасси` VARCHAR(60),  
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

CREATE TABLE `Колесная формула` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Формула` VARCHAR(20),  
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

CREATE TABLE `Материал цистерны` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Материал` VARCHAR(100),  
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

CREATE TABLE `Диаметр люков` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Диаметр` INTEGER,  
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;



CREATE TABLE `Молоковоз` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(60), 
  `Экологический класс` INTEGER, 
  `Базовое шасси` INTEGER, 
  `Колесная формула` INTEGER, 
  `Рабочая вместительность, л` INTEGER, 
  `Количество секций, шт` INTEGER, 
  `Материал цистерны` INTEGER, 
  `Диаметр люков` INTEGER, 
  PRIMARY KEY (`Код`),  
  FOREIGN KEY(`Экологический класс`) REFERENCES `Экологический класс` (`Код`),
  FOREIGN KEY(`Базовое шасси`) REFERENCES `Базовое шасси` (`Код`),
  FOREIGN KEY(`Колесная формула`) REFERENCES `Колесная формула` (`Код`),
  FOREIGN KEY(`Материал цистерны`) REFERENCES `Материал цистерны` (`Код`),
  FOREIGN KEY(`Диаметр люков`) REFERENCES `Диаметр люков` (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;


CREATE TABLE `Пост` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(30), 
  `Описание` VARCHAR(255), 
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

CREATE TABLE `Должность` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(60),
  `ЗП` INTEGER,  
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;

CREATE TABLE `Сотрудник` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `ФИО` VARCHAR(255), 
  `Дата рождения` DATETIME, 
  `Телефон` VARCHAR(20), 
  `Почта` VARCHAR(60), 
  `Адрес` VARCHAR(255), 
  `Должность` INTEGER, 
  PRIMARY KEY (`Код`),
  FOREIGN KEY(`Должность`) REFERENCES `Должность` (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;


CREATE TABLE `Приезд` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Молоковоз` INTEGER, 
  `Пост` INTEGER, 
  `Дата приезда` DATE, 
  `Время приезда` TIME, 
  `Количество привезенного молока, л` INTEGER DEFAULT 0, 
  `Начали мыть` TIME, 
  `Закончили мыть` TIME, 
  `Время выезда` TIME, 
  PRIMARY KEY (`Код`),
  foreign key(`Молоковоз`) references `Молоковоз` (`Код`),
  foreign key(`Пост`) references `Пост` (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;



CREATE TABLE `Обслуживание` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Приезд` INTEGER, 
  `Сотрудник` INTEGER, 
  PRIMARY KEY (`Код`),
  foreign key(`Приезд`) references `Приезд` (`Код`),
  foreign key(`Сотрудник`) references `Сотрудник` (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;
SET autocommit=1;