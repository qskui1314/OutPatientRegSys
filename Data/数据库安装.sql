--/*
--����Һ�ϵͳ���ݿ�
--*/
----�������ݿ⣻
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
--������
----����Ա��
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
--ҽ�ƿ���
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
        datetime
    ,coTime
        datetime);
--���߱�
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
        datetime
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
--���ұ�
CREATE TABLE tb_dept
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
--ҽ����
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
        datetime
    ,limitNum
        int
    ,numLeft
        int);
--�Һű�
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
    ,regdate
        datetime
        NOT NULL
    ,opUser
        VARCHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_operator(No));
--��Ʊ��
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
        datetime
        NOT NULL
    ,charge
        money
        NOT NULL
        DEFAULT '0.00');

--���ֱ�
CREATE TABLE tb_drgs
    (NO
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
--�Ҵ��ǼǱ�
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
        datetime
        NOT NULL
    ,endDate
        datetime
        NOT NULL);
--�Ű��
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

INSERT tb_operator
    (No,Name,Password)
    VALUES
    ('3150707035','��˼��',HASHBYTES('MD5','7035'));
INSERT tb_operator
    (No,Name,Password)
    VALUES
    ('3150707012','�',HASHBYTES('MD5','7012'));
INSERT tb_operator
    (No,Name,Password)
    VALUES
    ('3150707046','�޲�',HASHBYTES('MD5','7046'));