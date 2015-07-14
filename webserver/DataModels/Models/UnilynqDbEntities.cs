using DataModels.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Models
{
    public class UnilynqDbEntities : DbContext
    {
        public UnilynqDbEntities()
            : base("name=UnilynqDb")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<ContactUq> ContactUqs { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<GroupChat> GroupChats { get; set; }
        public DbSet<LynQAssLoad> LynQAssLoads { get; set; }
        public DbSet<LynQChatBlocker> LynQChatBlockers { get; set; }
        public DbSet<LynQChatBox> LynQChatBoxes { get; set; }
        public DbSet<LynQChatSetting> LynQChatSettings { get; set; }
        public DbSet<LynQComment> LynQComments { get; set; }
        public DbSet<LynQDepartment> LynQDepartments { get; set; }
        public DbSet<LynQderEvent> LynQderEvents { get; set; }
        public DbSet<LynQDocumentation> LynQDocumentations { get; set; }
        public DbSet<LynQer> LynQers { get; set; }
        public DbSet<LynQersComChat> LynQersComChats { get; set; }
        public DbSet<LynQForum> LynQForums { get; set; }
        public DbSet<LynQFriend> LynQFriends { get; set; }
        public DbSet<LynQGenTrailStu> LynQGenTrailStus { get; set; }
        public DbSet<LynQGradeClass> LynQGradeClasses { get; set; }
        public DbSet<LynQGrade> LynQGrades { get; set; }
        public DbSet<LynQGroup> LynQGroups { get; set; }
        public DbSet<LynQGrpMem> LynQGrpMems { get; set; }
        public DbSet<LynQInfoBoard> LynQInfoBoards { get; set; }
        public DbSet<LynQLectAssignCode> LynQLectAssignCodes { get; set; }
        public DbSet<LynQLectAssignElect> LynQLectAssignElects { get; set; }
        public DbSet<LynQLectAssignOptn> LynQLectAssignOptns { get; set; }
        public DbSet<LynQLoadersTemp> LynQLoadersTemps { get; set; }
        public DbSet<LynQLoad> LynQLoads { get; set; }
        public DbSet<LynQMajor> LynQMajors { get; set; }
        public DbSet<LynQMajorStu> LynQMajorStus { get; set; }
        public DbSet<LynQOfflineChat> LynQOfflineChats { get; set; }
        public DbSet<LynQPost> LynQPosts { get; set; }
        public DbSet<LynQProgram> LynQPrograms { get; set; }
        public DbSet<LynQQueAn> LynQQueAns { get; set; }
        public DbSet<LynQQue> LynQQues { get; set; }
        public DbSet<LynQQuizAn> LynQQuizAns { get; set; }
        public DbSet<LynQQuizQue> LynQQuizQues { get; set; }
        public DbSet<LynQQuiz> LynQQuizes { get; set; }
        public DbSet<LynQRequirement> LynQRequirements { get; set; }
        public DbSet<LynQRSVP> LynQRSVPs { get; set; }
        public DbSet<LynQSchCalendar> LynQSchCalendars { get; set; }
        public DbSet<LynQSchool> LynQSchools { get; set; }
        public DbSet<LynQScoDetail> LynQScoDetails { get; set; }
        public DbSet<LynQScoMultiChoice> LynQScoMultiChoices { get; set; }
        public DbSet<LynQScore> LynQScores { get; set; }
        public DbSet<LynQScotion> LynQScotions { get; set; }
        public DbSet<LynQSubAssign> LynQSubAssigns { get; set; }
        public DbSet<LynQTAd> LynQTAds { get; set; }
        public DbSet<LynQTradeChat> LynQTradeChats { get; set; }
        public DbSet<NGrade_ProV> NGrade_ProV { get; set; }
        public DbSet<NGrade> NGrades { get; set; }
        public DbSet<NRegistration> NRegistrations { get; set; }
        public DbSet<Skulz> Skulz { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Trail_List> Trail_List { get; set; }
        public DbSet<UChat> UChats { get; set; }
        public DbSet<UqCoding> UqCodings { get; set; }
        public DbSet<UqTimeLine> UqTimeLines { get; set; }
        public DbSet<Why> Why { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //add table mapping rules after discussing relationships with Israel
            modelBuilder.Configurations.Add(new LynQerMapper());

            base.OnModelCreating(modelBuilder);
        }
    }
}
