/*
门诊挂号系统数据库
*/
创建数据库；
USE master;
IF DB_ID('ORSBase') IS NOT NULL
	BEGIN
		ALTER DATABASE ORSBase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE ORSBase;
	END
CREATE DATABASE ORSBase
	ON
		(NAME='Datafile'
		,FILENAME='E:\ORSDataFile.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='E:\ORSLogfile.ldf');
GO
USE ORSBase;
创建表；
--操作员表；
CREATE TABLE tb_operator
    (No 
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,password
        VARBINARY(128)
        NOT NULL);
INSERT tb_operator
    (No,Name,Password)
    VALUES
    ('3150707035','邱思奎',HASHBYTES('MD5','7035'))
    ,('3150707012','李靖',HASHBYTES('MD5','7012'))
    ,('3150707046','崔灿',HASHBYTES('MD5','7046'));
--医疗卡表；
CREATE TABLE tb_card
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,balance
        money
        NOT NULL
        DEFAULT '0.00'
    ,enMoney
        money
    ,coMoney
        money
    ,enTime
        date
    ,coTime
        date);
--患者表；
CREATE TABLE tb_patient
    (No
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,age
        int
        NOT NULL
    ,sex
        bit
        NOT NULL
    ,birthday
        date
        NOT NULL
    ,birthProv
        varchar(25)
    ,birthCity
        varchar(25)
    ,nationality
        varchar(25)
    ,socialNo
        VARCHAR(18)
    ,tel
        VARCHAR(15)
        NOT NULL
    ,cardNo
        VARCHAR(10)
        FOREIGN KEY REFERENCES tb_card(NO)
    ,Address
        varchar(25)
        NOT NULL);
--科室表；
CREATE TABLE tb_dept
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
--医生表；
CREATE TABLE tb_doctor
    (No
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        VARCHAR(10)
        NOT NULL
    ,title
        varchar(25)
        NOT NULL
    ,deptNo
        VARCHAR(10)
        FOREIGN KEY REFERENCES tb_dept(No)
    ,visitTime
        date
    ,limitNum
        int
    ,numLeft
        int);
--挂号表；
CREATE TABLE tb_register
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,regType
        varchar(25)
        NOT NULL
    ,PRIORITY
        int
        NOT NULL
        DEFAULT '0'
    ,patientNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_patient(No)
    ,deptNo
        VARCHAR(10)
        FOREIGN KEY REFERENCES tb_dept(No)
    ,docNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_doctor(No)
    ,regFee
        money
        NOT NULL
        DEFAULT '0.00'
    ,medFee
        money
        NOT NULL
        DEFAULT '0.00'
    ,regDate
        date
        NOT NULL
    ,opUser
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_operator(No));
--发票表；
CREATE TABLE tb_receipt
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,regNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_register(No)
    ,patientNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_patient(No)
    ,recDate
        date
        NOT NULL
    ,charge
        money
        NOT NULL
        DEFAULT '0.00');

--病种表；
CREATE TABLE tb_drgs
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
--家床登记表；
CREATE TABLE tb_bedReg
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,drgsNo
        VARCHAR(10)
        FOREIGN KEY REFERENCES tb_drgs(No)
    ,deptNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_dept(No)
    ,receiptNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_receipt(No)
    ,beginDate
        date
        NOT NULL
    ,endDate
        date
        NOT NULL);
--排班表；
CREATE TABLE tb_schedual
    (weekday
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,deptNo
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_dept(No)
    ,docNo
        VARCHAR(10)
        NOT NULL
        UNIQUE
        FOREIGN KEY REFERENCES tb_doctor(No)
    ,num
        int
        NOT NULL
    ,numLeft
        int
        NOT NULL);