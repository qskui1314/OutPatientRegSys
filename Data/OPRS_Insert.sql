/*
门诊挂号系统数据库--数据插入
*/
USE OPRSBase;	

----医院信息表--插入医院数据；
INSERT INTO tb_Hospital
	(name,address,signUpCode)
	VALUES
	('福建中医院大学附属医院','福建省福州市闽侯县上街镇邱阳路1号','3150707012');
		
----患者表--插入患者数据；                ---添加数据
INSERT dbo.tb_patient
		( No ,
		  Name ,
		  age ,
		  sex ,
		  birthday ,
		  nationality ,
		  nation ,
		  email ,
		  tel ,
		  Address ,
		  firstMan1 ,
		  firstManTel1 ,
		  firstMan2 ,
		  firstManTel2 ,
		  id,
		  visitNo,
		  regDate ,
		  allergyHistory ,
		  operationHistory
		)
VALUES  ( '20171112102319' , -- No - char(15)
		  '张三' , -- Name - varchar(25)
		  20 , -- age - int
		  0 , -- sex - bit
		  '1997-11-12' , -- birthday - date
		  '中国' , -- nationality - varchar(25)
		  '汉' , -- nation - varchar(15)
		  'asd@f.com' , -- email - char(45)
		  '18356438763' , -- tel - char(15)
		  '福建省福州市闽侯县上街镇邱阳路1号' , -- Address - varchar(45)
		  '张一' , -- firstMan1 - varchar(25)
		  '18276478345' , -- firstManTel1 - char(15)
		  '张二' , -- firstMan2 - varchar(25)
		  '18297346592' , -- firstManTel2 - char(15)
		  '365745199711126376' , -- id - char(18)
		  '20171112001' , -- visitno - char(15)
		  '2017-11-12' , -- regDate - date
		  '无' , -- allergyHistory - varchar(255)
		  '无'),  -- operationHistory - varchar(255)
		  ( '20171116104903' , -- No - char(15)
		  '李四' , -- Name - varchar(25)
		  21 , -- age - int
		  1 , -- sex - bit
		  '1996-11-12' , -- birthday - date
		  '中国' , -- nationality - varchar(25)
		  '汉' , -- nation - varchar(15)
		  'qwe@r.com' , -- email - char(45)
		  '18332359125' , -- tel - char(15)
		  '福建省福州市闽侯县上街镇邱阳路1号' , -- Address - varchar(45)
		  '李一' , -- firstMan1 - varchar(25)
		  '18276489878' , -- firstManTel1 - char(15)
		  '李二' , -- firstMan2 - varchar(25)
		  '18215234675' , -- firstManTel2 - char(15)
		  '432312199611124323' , -- id - char(18)
		  NULL , -- visitno - char(15)
		  '2017-11-16' , -- regDate - date
		  '芒果过敏' , -- allergyHistory - varchar(255)
		  '无')  -- operationHistory - varchar(255))
		  
		  
----就诊/医疗卡表--插入就诊/医疗卡数据；            ---添加数据
INSERT dbo.tb_card
        ( patientNo ,
          cardType ,
          id ,
          visitNo ,
          creditLimit ,
          balance
        )
VALUES  ( '20171112102319' , -- patientNo - char(15)
          0 , -- cardType - bit
          NULL , -- id - char(18)
          '20171112001' , -- visitNo - char(15)
          100 , -- creditLimit - money
          300  -- balance - money
        ),
        ( '20171116104903' , -- patientNo - char(15)
          0 , -- cardType - bit
          '432312199611124323' , -- id - char(18)
          NULL , -- visitNo - char(15)
          50 , -- creditLimit - money
          100  -- balance - money
        );    
        
        
----费用记录表--插入费用记录数据；         ---添加数据
INSERT dbo.tb_expensesRecord
        ( ticketNo ,
          patientNo ,
          id ,
          visitNo ,
          regNo ,
          docNo ,
          medicineFee ,
          examFee ,
          checkFee ,
          diagFee ,
          regFee ,
          payDate
        )
VALUES  ( '020171119001' , -- ticketNo - char(10)
          '20171112102319' , -- patientNo - char(15)
          NULL , -- id - char(18)
          '20171112001' , -- visitNo - char(15)
          1 , -- regNo - int
          '0001' , -- docNo - varchar(10)
          45.5 , -- medicineFee - money
          140 , -- examFee - money
          12 , -- checkFee - money
          36 , -- diagFee - money
          28 , -- regFee - money
          NULL  -- payDate - datetime
        ); 
        
        
----科室表--插入科室数据；
INSERT dbo.tb_dept
		( NO,NAME )
VALUES  ( '1','内科')
		,('2','外科')
		,('3','妇产科')
		,('4','儿科')
		,('5','眼科')
		,('6','耳鼻咽喉科')
		,('7','口腔科')
		,('8','皮肤科')
		,('9','管理科室')
		,('10','精神科')
		,('11','康复医学科')
		,('12','全科医疗科')
		,('13','医学影像科')
		,('14','中医科')
		,('15','肿瘤科');
		
		
----医生表--插入医生数据；
INSERT dbo.tb_doctor
	( No ,
	  NAME ,
	  title ,
	  deptNo ,
	  specialty
	)
VALUES  ( '0001' , '邹良能' , '主任医师' , '1' , '擅长慢性顽固性咳嗽、肺部感染、COPD、支气管扩张、肺结核、胸膜炎等呼吸疾病诊治及咯血、呼吸衰竭等危重症抢救，率先开展肺癌分子靶向治疗等精准医疗。'),
	( '0002' , '林金环' , '主治医师' , '1' , '长期从事内科临床工作，擅长呼吸内科、消化内科、内分泌科、高血压病等的诊治。'),
	( '0003' , '邱明辉' , '主任医师' , '2' , '参加工作以来一直从事骨科临床工作至今，积累了丰富的专业知识和临床医疗经验。在创伤骨科、关节外科领域造诣颇深。擅长关节、脊柱创伤、疾病的诊治及膝关节镜下微创手术。'),
	( '0004' , '李春阳' , '副主任医师' , '2' , '从事普外临床工作20余年，积累了丰富的临床经验。掌握了腔镜技术，已熟练开展了腹腔镜胆囊切除术、疝气修补术、脾切除术、胃肠手术、手汗症手术等。'),
	( '0005' , '张燕' , '副主任医师' , '3' , '从事妇产科临床工作20余年，具有扎实的理论基础和丰富的临床经验。近年开展了徒手旋转胎头治疗头位难产和子宫背带式缝合加子宫动脉上行支缝扎术治疗剖宫产术中的大出血。'),
	( '0006' , '崔晓洁' , '主任医师' , '3' , '擅长月经失调、不孕症、子宫肌瘤、卵巢囊肿、盆腔炎性疾病、子宫内膜异位症、慢性盆腔痛、妊娠相关疾病（流产、保胎、滋养细胞疾病等）的诊治。'),
	( '0007' , '洪山' , '主任医师' , '4' , '对儿科常见病多发病有丰富临床经验。擅长小儿呼吸、消化、儿童重症及过敏性紫癜、川崎病等疾病的诊治。'),
	( '0008' , '朱上敏' , '副主任医师' , '4' , '擅长儿童哮喘、慢性咳嗽、过敏性咳嗽等的诊治。对儿科危重症及部分疑难病的诊治有较丰富的临床经验。'),
	( '0009' , '陈胡挪' , '副主任医师' , '5' , '从事眼科临床、教学工作近30年，擅长白内障、青光眼、眼底病、眼表疾病以及屈光不正等眼科疾病的诊治。'),
	( '0010' , '丁丽远' , '主任医师' , '5' , '从事眼科临床、教学及科研工作20余年，具有较强的眼科专业水平。擅长青光眼、眼底病、眼创伤、眼表疾病的诊治。'),
	( '0011' , '刘海楼' , '主任医师' , '6' , '毕业后一直从事耳鼻咽喉临床工作，对多发病、疑难危重疾病的诊治及手术积累了丰富的经验。熟练开展了耳鼻咽喉科各种手术，如鼻内窥镜下鼻腔及鼻窦手术、中耳炎手术、喉部疾病手术等。'),
	( '0012' , '洪海填' , '副主任医师' , '6' , '从事耳鼻咽喉科临床工作20余年，对本科常见病、多发病及疑难病的诊治有丰富临床经验。在变应性鼻炎的综合治疗、鼻微创外科、鼻内镜手术治疗慢性鼻炎、鼻息肉、鼻窦炎、鼻中隔偏曲'),
	( '0013' , '庄培尧' , '副主任医师' , '7' , '擅长根管治疗术，常规全口义齿、活动义齿、固定桥修复、烤瓷牙、光固化前牙美容修复以及覆盖义齿、套筒管、附着体等修复。'),
	( '0014' , '张洪活' , '主任医师' , '7' , '现从事口腔颌面外科及口腔科综合门诊工作。擅长唇、腭裂修复，口腔颌面部肿瘤、涎腺疾病的诊治，颌骨骨折切开复位内固定术等颌面外科手术；光固化前牙美容修复，种植牙、烤瓷牙等。'),
	( '0015' , '卢海刚' , '主任医师' , '8' , '治疗带状疱疹、痤疮、荨麻疹、白癜风、红斑狼疮、皮肌炎、硬皮病等疾病。'),
	( '0016' , '张秀钦' , '主治医师' , '8' , '各种皮炎、湿疹、荨麻疹、癣、疣、疱疹、痤疮、脱发、银屑病、红斑狼疮、血管炎等皮肤科常见病及疑难病的诊治；在淋病、梅毒、尖锐湿疣等性病的诊治及皮肤美容激光方面亦有丰富的临床经验。'),
	( '0017' , '薛秀兰' , '副主任医师' , '9' , '从事感染科专业20余年，临床经验丰富。擅长感染科常见病和多发疾病的诊断和治疗，对肝炎特别是病毒性和自身免疫性肝炎有独特见解和治疗策略。'),
	( '0018' , '汤文杰' , '主任医师' , '9' , ''),
	( '0019' , '陈进东' , '主任医师' , '10' , '擅长中西医结合治疗抑郁症、强迫症、失眠症及精神分裂症等各类精神心理疾病。'),
	( '0020' , '苏志斌' , '主治医师' , '10' , '擅长于失眠症、焦虑症、神经性疼痛、抑郁症、躁狂症、精神分裂症等的诊治。'),
	( '0021' , '张芸' , '主任医师' , '11' , '擅长：1）针灸治疗儿童脑瘫、中风恢复期、脊髓损伤恢复期；2）针灸治疗带状疱疹后遗神经痛、老年性骨质疏松症致腰背疼痛、颈椎病、腰椎间盘突出症、退行性骨关节病；3）针药结合'),
	( '0022' , '李泰标' , '主任医师' , '11' , '擅长：1、脑卒中、脑外伤、脊髓损伤及骨折术后功能障碍的评估与康复。2、医健结合，在姿势评估基础上，结合肌筋膜链、拉伸疗法和普拉提技术开展颈肩腰腿痛的运动康复；3、头痛、眩晕、中风、失眠、颈肩腰腿痛、咳喘及胃肠功能紊乱等常见病、多发病、慢性病的中医诊治及亚健康管理。'),
	( '0023' , '傅翔' , '主任医师' , '12' , '擅长呼吸科急危重病症处理及慢性阻塞性肺疾病、肺心病、哮喘、胸膜炎、大咯血等呼吸疾病的诊冶。'),
	( '0024' , '陈佳山' , '主任医师' , '12' , '擅长消化、呼吸内科及老年病等内科疑难病例诊治及急危重症抢救。'),
	( '0025' , '吴红平' , '副主任医师' , '13' , '擅长：1、肿瘤的介入治疗；2、血管疾病的腔内治疗（血管成形术和支架置入术）；3、妇产科相关的介入治疗（子宫肌瘤栓塞、宫颈癌化疗栓塞及产后出血）；4、消化科相关的介入'),
	( '0026' , '黄劲雄' , '副主任医师' , '13' , '擅长：甲亢、骨转移性肿瘤治疗'),
	( '0027' , '苏炳伟' , '副主任医师' , '14' , '从医20余年，在中西医治疗慢性胃炎、消化性溃疡、肝病、脑中风后遗症等疾病方面有丰富的临床经验。擅长运用中西医结合的方法治疗消化系统及呼吸系统疾病。'),
	( '0028' , '杨叔禹' , '主任医师' , '14' , '擅长：中医内科疾病，糖尿病慢性并发症；肿瘤手术后及放、化疗后中医药调理；脾胃虚弱及睡眠障碍、多汗、亚健康调理等。'),
	( '0029' , '薛增福' , '副主任医师' , '15' , '擅长：癌前病变及恶性肿瘤的早诊早治（胃癌、大肠癌、肺癌、食管癌、肝癌、乳腺癌等），消化道早期肿瘤的诊疗，基因筛查咨询等'),
	( '0030' , '张映红' , '主任医师' , '15' , '擅长：肺癌、乳腺癌、恶性淋巴瘤、胃癌、大肠癌、鼻咽癌等恶性肿瘤的内科治疗。');
	
	
----预约挂号表--插入预约挂号数据;        ---添加数据
INSERT dbo.tb_registration
		( patientNo ,
		  deptNo ,
		  docNo ,
		  regDate ,
		  regTime ,
		  operater
		)
SELECT '20171112102319',d2.NO,d1.No,'2017-11-12','08:23:19','3150707012'
FROM 
	dbo.tb_doctor d1 
	JOIN dbo.tb_dept d2 ON d1.deptNo = d2.NO 
WHERE d1.NAME='邹良能' AND d2.NAME='内科';    


----挂号类别表--插入挂号类别数据；  
INSERT dbo.tb_regType
		( NAME, price )
VALUES  ('普通门诊',13)
	   ,('专家门诊',28);
	   
	   
----医生评价表--插入评价数据；  ---添加数据
INSERT dbo.tb_docScore
        ( patientNo ,
          docNo ,
          score ,
          comments ,
          comDate
        )
VALUES  ( '20171112102319' , -- patientNo - char(15)
          '0001' , -- docNo - varchar(10)
          '好' , -- score - varchar(10)
          '无' , -- comments - varchar(455)
          '2017-11-16 06:40:12'  -- comDate - date
        ); 