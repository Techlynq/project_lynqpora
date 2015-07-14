namespace Unilynq.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        Receiver = c.String(),
                        Message = c.String(),
                        LynQDate = c.DateTime(),
                        LynQTime = c.Time(precision: 7),
                        LynQDT = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactUqs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Emailadd = c.String(),
                        Date = c.DateTime(),
                        Message = c.String(),
                        Contact = c.String(),
                        Solved = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        LynQManager = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        LynQSch = c.String(),
                        Forum_Expo = c.String(),
                        ForumScope = c.String(),
                        Messages = c.Int(),
                        Forumimg = c.String(),
                        ForumDate = c.DateTime(),
                        Likes = c.Int(),
                        DisLikes = c.Int(),
                        Likers = c.String(),
                        Dislikers = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Gamers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        player1 = c.String(),
                        player2 = c.String(),
                        saved = c.String(),
                        date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQGrpName = c.String(),
                        LynQName = c.String(),
                        Message = c.String(),
                        SendDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQAssLoads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQGrpName = c.String(),
                        AssName = c.String(),
                        DateTimer = c.DateTime(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQChatBlockers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        Blockee = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQChatBoxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQBoxP1 = c.String(),
                        LynQBoxP2 = c.String(),
                        LynQBoxP3 = c.String(),
                        LynQBoxC1 = c.String(),
                        LynQBoxC2 = c.String(),
                        LynQBoxC3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQChatSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        ChatSS = c.String(),
                        ChatSL = c.String(),
                        ChatSH = c.String(),
                        ChatLL = c.String(),
                        ChatLH = c.String(),
                        ChatHH = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostID = c.Int(),
                        LynQName = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        ComDate = c.DateTime(),
                        LynQProg = c.String(),
                        Comment = c.String(),
                        Commimg = c.String(),
                        imgDescrip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQDepartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSchool = c.String(),
                        SchoolName = c.String(),
                        DeptName = c.String(),
                        LynQUserid = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQderEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQGroup = c.String(),
                        date = c.DateTime(),
                        endd = c.DateTime(),
                        LynQEvent = c.String(),
                        borderColor = c.String(),
                        backgroundColor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQDocumentations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        DocTitle = c.String(),
                        DocContent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQUserid = c.String(),
                        LynQFstname = c.String(),
                        LynQLstname = c.String(),
                        LynQOnames = c.String(),
                        LynQFname = c.String(),
                        LynQGender = c.String(),
                        LynQAge = c.DateTime(),
                        LynQerimg = c.String(),
                        LynQSch = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        LynQStatus = c.String(),
                        LynQTivity = c.String(),
                        LynQInterest = c.String(),
                        CommentsViewed = c.String(),
                        Email = c.String(),
                        Rakeit = c.String(),
                        N_image = c.Binary(),
                        G_image = c.Binary(),
                        I_image = c.Binary(),
                        LynQLevell = c.String(),
                        LynQActive = c.Int(),
                        LynQUniqID = c.String(),
                        Privacy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQersComChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RealID = c.Int(nullable: false),
                        CommId = c.String(),
                        MessCom = c.String(),
                        Mesdate = c.DateTime(),
                        LynQFname = c.String(),
                        LynQerimg = c.String(),
                        LynQSch = c.String(),
                        LynQSchimg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQForums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        realID = c.Int(nullable: false),
                        Title = c.String(),
                        LynQName = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        PostDate = c.DateTime(),
                        Message = c.String(),
                        LynQSch = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        Likes = c.Int(),
                        Dislikes = c.Int(),
                        LynQLikers = c.String(),
                        LynQDislikers = c.String(),
                        Postimgs = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQFriends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQId = c.Int(nullable: false),
                        LynQer = c.String(),
                        LynQee = c.String(),
                        LynQedDate = c.DateTime(nullable: false),
                        LynQStatus = c.String(),
                        LynQerPic = c.String(),
                        LynQeePic = c.String(),
                        LynQerFname = c.String(),
                        LynQeeFname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQGenTrailStus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        LynQName = c.String(),
                        Code = c.String(),
                        ExamID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQGradeClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSchool = c.String(),
                        StudClass = c.String(),
                        LstValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSchool = c.String(),
                        GradSys = c.String(),
                        CMK = c.Decimal(precision: 18, scale: 2),
                        EMK = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQGpName = c.String(),
                        GPAdmin = c.String(),
                        GPDate = c.DateTime(),
                        GrPurpose = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQGrpMems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQGpName = c.String(),
                        MemDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQInfoBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        LynQName = c.String(),
                        Scope = c.String(),
                        Info = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQLectAssignCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        AssignedBy = c.String(),
                        AssignedTo = c.String(),
                        Code = c.String(),
                        UqGrpName = c.String(),
                        Program = c.String(),
                        DateAssigned = c.DateTime(nullable: false),
                        Levell = c.String(),
                        Semester = c.Int(nullable: false),
                        UploadStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQLectAssignElects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        AssignedBy = c.String(),
                        AssignedTo = c.String(),
                        Optn = c.String(),
                        NumbSel = c.Int(nullable: false),
                        Code = c.String(),
                        UqGrpName = c.String(),
                        Program = c.String(),
                        DateAssigned = c.DateTime(nullable: false),
                        Levell = c.String(),
                        Semester = c.Int(nullable: false),
                        UploadStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQLectAssignOptns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        AssignedBy = c.String(),
                        AssignedTo = c.String(),
                        Code = c.String(),
                        UqGrpName = c.String(),
                        Program = c.String(),
                        Optn = c.String(),
                        DateAssigned = c.DateTime(nullable: false),
                        Levell = c.String(),
                        Semester = c.Int(nullable: false),
                        UploadStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQLoadersTemps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQLoaders = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQLoads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        Receiver = c.String(),
                        FileType = c.String(),
                        DateTimer = c.DateTime(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQMajors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSchool = c.String(),
                        SchoolName = c.String(),
                        DeptName = c.String(),
                        ProgName = c.String(),
                        Major_Optn = c.String(),
                        LynQUserid = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQMajorStus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynSch = c.String(),
                        LynQName = c.String(),
                        ExamID = c.String(),
                        Optn = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQOfflineChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        Receiver = c.String(),
                        MessageNo = c.Int(),
                        LynQLoads = c.Int(),
                        LynQDT = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        LynQName = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        PostDate = c.DateTime(),
                        ComDate = c.DateTime(),
                        Message = c.String(),
                        LynQSch = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        PostLikes = c.Int(),
                        PostDislikes = c.Int(),
                        LynQLikers = c.String(),
                        LynQDislikers = c.String(),
                        PostStartimg = c.String(),
                        StartimgDescrip = c.String(),
                        Postimgs = c.String(),
                        imgDescrip = c.String(),
                        PostComments = c.Int(),
                        PostScope = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQPrograms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSchool = c.String(),
                        SchoolName = c.String(),
                        DeptName = c.String(),
                        ProgName = c.String(),
                        LynQUserid = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQQueAns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        realID = c.Int(nullable: false),
                        LynQName = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        Ansdate = c.DateTime(),
                        Answer = c.String(),
                        LynQSch = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        Likes = c.Int(),
                        Dislikes = c.Int(),
                        LynQLikers = c.String(),
                        LynQDislikers = c.String(),
                        Ansimgs = c.String(),
                        AnsChecked = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQQues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QueryID = c.String(),
                        LynQquery = c.String(),
                        LynQquerier = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        LynQSch = c.String(),
                        QueryScope = c.String(),
                        AnswersProv = c.Int(),
                        Likes = c.Int(),
                        DisLikes = c.Int(),
                        Likers = c.String(),
                        Dislikers = c.String(),
                        QueryStatus = c.String(),
                        Queryimg = c.String(),
                        Quedate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQQuizAns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        queid = c.Int(nullable: false),
                        alpha = c.String(),
                        lynqans = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQQuizs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQGrpName = c.String(),
                        QuizName = c.String(),
                        Submissions = c.Int(),
                        calid = c.Int(),
                        Hrs = c.Int(),
                        Min = c.Int(),
                        Sec = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQQuizQues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQGrpName = c.String(),
                        quizname = c.String(),
                        lynqtion = c.String(),
                        lynQAns = c.String(),
                        lynqrect = c.Int(),
                        lynqrong = c.Int(),
                        lynqrecters = c.String(),
                        lynqrongers = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQRequirements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        ReqType = c.String(),
                        Levell = c.String(),
                        Opera = c.String(),
                        Premise = c.String(),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Semester = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQRSVPs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        LynQName = c.String(),
                        LynQSites = c.String(),
                        LynQScope = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQSchCalendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        LynQGroup = c.String(),
                        date = c.DateTime(),
                        endd = c.DateTime(),
                        LynQEvent = c.String(),
                        borderColor = c.String(),
                        backgroundColor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQSchools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSchool1 = c.String(),
                        SchoolName = c.String(),
                        LynQUserid = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQScoDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        Type = c.String(),
                        Year = c.String(),
                        Course = c.String(),
                        Descr = c.String(),
                        Hrs = c.Int(),
                        Min = c.Int(),
                        Sec = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQScoMultiChoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QNo = c.Int(),
                        Answers = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQScores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQName = c.String(),
                        Score = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQScotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QNo = c.Int(),
                        lynqtion = c.String(),
                        lynqAns = c.String(),
                        lynqrecters = c.String(),
                        lynqwrongers = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQSubAssigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQGrpName = c.String(),
                        AssName = c.String(),
                        Submissions = c.Int(),
                        calid = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQTAds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdId = c.String(),
                        LynQITcategory = c.String(),
                        LynQITName = c.String(),
                        LynQITdesc = c.String(),
                        LynQName = c.String(),
                        LynQFname = c.String(),
                        LynQimg = c.String(),
                        LynQSchimg = c.String(),
                        LynQProg = c.String(),
                        LynQSch = c.String(),
                        LynQITPrice = c.String(),
                        LynQersInterested = c.Int(),
                        Likes = c.Int(),
                        DisLikes = c.Int(),
                        Likers = c.String(),
                        Dislikers = c.String(),
                        ITStatus = c.String(),
                        Itemimg = c.String(),
                        AdDate = c.DateTime(),
                        LynQTphony = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LynQTradeChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RealID = c.Int(nullable: false),
                        Tradeid = c.Int(),
                        MessCom = c.String(),
                        Mesdate = c.DateTime(),
                        LynQFname = c.String(),
                        LynQerimg = c.String(),
                        LynQSch = c.String(),
                        LynQSchimg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NGrade_ProV",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        GradeCode = c.String(),
                        ExamID = c.String(),
                        Name = c.String(),
                        Gender = c.String(),
                        Dept = c.String(),
                        ProgStudy = c.String(),
                        Optn = c.String(),
                        Levell = c.String(),
                        Study_type = c.String(),
                        Acadyear = c.String(),
                        Semester = c.Int(),
                        Code = c.String(),
                        Course = c.String(),
                        Credit = c.Int(),
                        Grad = c.String(),
                        Gp = c.Decimal(precision: 18, scale: 2),
                        CMk = c.Decimal(precision: 18, scale: 2),
                        EMk = c.Decimal(precision: 18, scale: 2),
                        Mk = c.Decimal(precision: 18, scale: 2),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        GradeCode = c.String(),
                        ExamID = c.String(),
                        Name = c.String(),
                        Gender = c.String(),
                        Dept = c.String(),
                        ProgStudy = c.String(),
                        Optn = c.String(),
                        Levell = c.String(),
                        Study_type = c.String(),
                        Acadyear = c.String(),
                        Semester = c.Int(),
                        Code = c.String(),
                        Course = c.String(),
                        Credit = c.Int(),
                        Grad = c.String(),
                        Gp = c.Decimal(precision: 18, scale: 2),
                        CMk = c.Decimal(precision: 18, scale: 2),
                        EMk = c.Decimal(precision: 18, scale: 2),
                        Mk = c.Decimal(precision: 18, scale: 2),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        ExamID = c.String(),
                        Name = c.String(),
                        Gender = c.String(),
                        Dept = c.String(),
                        ProgStudy = c.String(),
                        Optn = c.String(),
                        Levell = c.String(),
                        RDate = c.DateTime(),
                        Study_type = c.String(),
                        Acadyear = c.String(),
                        Semester = c.Int(),
                        Code = c.String(),
                        Course = c.String(),
                        Credit = c.Int(),
                        Grad = c.String(),
                        Gp = c.Decimal(precision: 18, scale: 2),
                        CMk = c.Decimal(precision: 18, scale: 2),
                        EMk = c.Decimal(precision: 18, scale: 2),
                        Mk = c.Decimal(precision: 18, scale: 2),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skulzs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Schools = c.String(),
                        LynQSchimg = c.String(),
                        Abv = c.String(),
                        UploadStatus = c.String(),
                        Semester = c.Int(),
                        AcadYear = c.String(),
                        Study_Type = c.String(),
                        RenegadeChat = c.String(),
                        ExaminationService = c.String(),
                        AuthorDepts = c.String(),
                        RegStatus = c.String(),
                        SchName = c.String(),
                        SetCourses = c.String(),
                        SHS = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQId = c.Int(nullable: false),
                        state = c.String(),
                        LastEntry = c.String(),
                        Pic = c.String(),
                        LynQSchName = c.String(),
                        LynQSchPic = c.String(),
                        LynQFriends = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        TokenId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        AuthToken = c.String(),
                        IssuedOn = c.DateTime(nullable: false),
                        ExpiresOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TokenId);
            
            CreateTable(
                "dbo.Trail_List",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LynQSch = c.String(),
                        ExamID = c.String(),
                        ProgStudy = c.String(),
                        Code = c.String(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        Receiver = c.String(),
                        Message = c.String(),
                        LynQDate = c.DateTime(),
                        LynQTime = c.Time(precision: 7),
                        LynQDT = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UqCodings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        schid = c.Int(),
                        LynQSch = c.String(),
                        Code = c.String(),
                        Course = c.String(),
                        Credit = c.Int(),
                        Dept = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UqTimeLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        LynQName = c.String(),
                        Date = c.DateTime(),
                        LynQScope = c.String(),
                        refid = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Whies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Dame = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Whies");
            DropTable("dbo.UqTimeLines");
            DropTable("dbo.UqCodings");
            DropTable("dbo.UChats");
            DropTable("dbo.Trail_List");
            DropTable("dbo.Tokens");
            DropTable("dbo.Tags");
            DropTable("dbo.Status");
            DropTable("dbo.Skulzs");
            DropTable("dbo.NRegistrations");
            DropTable("dbo.NGrades");
            DropTable("dbo.NGrade_ProV");
            DropTable("dbo.LynQTradeChats");
            DropTable("dbo.LynQTAds");
            DropTable("dbo.LynQSubAssigns");
            DropTable("dbo.LynQScotions");
            DropTable("dbo.LynQScores");
            DropTable("dbo.LynQScoMultiChoices");
            DropTable("dbo.LynQScoDetails");
            DropTable("dbo.LynQSchools");
            DropTable("dbo.LynQSchCalendars");
            DropTable("dbo.LynQRSVPs");
            DropTable("dbo.LynQRequirements");
            DropTable("dbo.LynQQuizQues");
            DropTable("dbo.LynQQuizs");
            DropTable("dbo.LynQQuizAns");
            DropTable("dbo.LynQQues");
            DropTable("dbo.LynQQueAns");
            DropTable("dbo.LynQPrograms");
            DropTable("dbo.LynQPosts");
            DropTable("dbo.LynQOfflineChats");
            DropTable("dbo.LynQMajorStus");
            DropTable("dbo.LynQMajors");
            DropTable("dbo.LynQLoads");
            DropTable("dbo.LynQLoadersTemps");
            DropTable("dbo.LynQLectAssignOptns");
            DropTable("dbo.LynQLectAssignElects");
            DropTable("dbo.LynQLectAssignCodes");
            DropTable("dbo.LynQInfoBoards");
            DropTable("dbo.LynQGrpMems");
            DropTable("dbo.LynQGroups");
            DropTable("dbo.LynQGrades");
            DropTable("dbo.LynQGradeClasses");
            DropTable("dbo.LynQGenTrailStus");
            DropTable("dbo.LynQFriends");
            DropTable("dbo.LynQForums");
            DropTable("dbo.LynQersComChats");
            DropTable("dbo.LynQers");
            DropTable("dbo.LynQDocumentations");
            DropTable("dbo.LynQderEvents");
            DropTable("dbo.LynQDepartments");
            DropTable("dbo.LynQComments");
            DropTable("dbo.LynQChatSettings");
            DropTable("dbo.LynQChatBoxes");
            DropTable("dbo.LynQChatBlockers");
            DropTable("dbo.LynQAssLoads");
            DropTable("dbo.GroupChats");
            DropTable("dbo.Gamers");
            DropTable("dbo.Fora");
            DropTable("dbo.ContactUqs");
            DropTable("dbo.Chats");
        }
    }
}
