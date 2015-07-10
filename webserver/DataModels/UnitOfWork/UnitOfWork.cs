using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity.Validation;
using DataModel.GenericRepository;
using DataModels.Models;


namespace DataModel.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...

        private UnilynqDbEntities _context = null;
        private GenericRepository<Chat> _chatRepository;
        private GenericRepository<ContactUq> _contactUqRepository;
        private GenericRepository<Forum> _forumRepository;
        private GenericRepository<Gamer> _gamerRepository;
        private GenericRepository<GroupChat> _groupChatRepository;
        private GenericRepository<LynQAssLoad> _lynQAssLoadRepository;
        private GenericRepository<LynQChatBlocker> _lynQChatBlockerRepository;
        private GenericRepository<LynQChatBox> _lynQChatBoxRepository;
        private GenericRepository<LynQChatSetting> _lynQChatSettingRepository;
        private GenericRepository<LynQComment> _lynQCommentRepository;
        private GenericRepository<LynQDepartment> _lynQDepartmentRepository;
        private GenericRepository<LynQderEvent> _lynQderEventRepository;
        private GenericRepository<LynQDocumentation> _lynQDocumentationRepository;
        private GenericRepository<LynQer> _lynQerRepository;
        private GenericRepository<LynQersComChat> _lynQersComChatRepository;
        private GenericRepository<LynQForum> _lynQForumRepository;
        private GenericRepository<LynQFriend> _lynQFriendRepository;
        private GenericRepository<LynQGenTrailStu> _lynQGenTrailStuRepository;
        private GenericRepository<LynQGrade> _lynQGradeRepository;
        private GenericRepository<LynQGradeClass> _lynQGradeClassRepository;
        private GenericRepository<LynQGroup> _lynQGroupRepository;
        private GenericRepository<LynQGrpMem> _lynQGrpMemRepository;
        private GenericRepository<LynQInfoBoard> _lynQInfoBoardRepository;
        private GenericRepository<LynQLectAssignCode> _lynQLectAssignCodeRepository;
        private GenericRepository<LynQLectAssignElect> _lynQLectAssignElectRepository;
        private GenericRepository<LynQLectAssignOptn> _lynQLectAssignOptnRepository;
        private GenericRepository<LynQLoad> _lynQLoadRepository;
        private GenericRepository<LynQLoadersTemp> _lynQLoadersTempRepository;
        private GenericRepository<LynQMajor> _lynQMajorRepository;
        private GenericRepository<LynQMajorStu> _lynQMajorStuRepository;
        private GenericRepository<LynQOfflineChat> _lynQOfflineChatRepository;
        private GenericRepository<LynQPost> _lynQPostRepository;
        private GenericRepository<LynQProgram> _lynQProgramRepository;
        private GenericRepository<LynQQue> _lynQQueRepository;
        private GenericRepository<LynQQueAn> _lynQQueAnRepository;
        private GenericRepository<LynQQuiz> _lynQQuizRepository;
        private GenericRepository<LynQQuizAn> _lynQQuizAnRepository;
        private GenericRepository<LynQQuizQue> _lynQQuizQueRepository;
        private GenericRepository<LynQRequirement> _lynQRequirementRepository;
        private GenericRepository<LynQRSVP> _lynQRSVPRepository;
        private GenericRepository<LynQSchCalendar> _lynQSchCalendarRepository;
        private GenericRepository<LynQSchool> _lynQSchoolRepository;
        private GenericRepository<LynQScoDetail> _lynQScoDetailRepository;
        private GenericRepository<LynQScoMultiChoice> _lynQScoMultiChoiceRepository;
        private GenericRepository<LynQScore> _lynQScoreRepository;
        private GenericRepository<LynQScotion> _lynQScotionRepository;
        private GenericRepository<LynQSubAssign> _lynQSubAssignRepository;
        private GenericRepository<LynQTAd> _lynQTAdRepository;
        private GenericRepository<LynQTradeChat> _lynQTradeChatRepository;
        private GenericRepository<NGrade> _nGradeRepository;
        private GenericRepository<NGrade_ProV> _nGrade_ProVRepository;
        private GenericRepository<NRegistration> _nRegistrationRepository;
        private GenericRepository<Skulz> _skulzRepository;
        private GenericRepository<Status> _statusRepository;
        private GenericRepository<Tag> _tagRepository;
        private GenericRepository<Trail_List> _trail_ListRepository;
        private GenericRepository<UChat> _uChatRepository;
        private GenericRepository<UqCoding> _uqCodingRepository;
        private GenericRepository<UqTimeLine> _uqTimeLineRepository;
        private GenericRepository<Why> _whyRepository;
        
        #endregion

        public UnitOfWork()
        {
            _context = new UnilynqDbEntities();
        }

        #region Public Repository Creation properties...
        public GenericRepository<Chat> ChatRepository
        {
            get
            {
                if (this._chatRepository == null)
                    this._chatRepository = new GenericRepository<Chat>(_context);
                return _chatRepository;
            }
        }

        public GenericRepository<ContactUq> ContactUqRepository
        {
            get
            {
                if (this._contactUqRepository == null)
                    this._contactUqRepository = new GenericRepository<ContactUq>(_context);
                return _contactUqRepository;
            }
        }

        public GenericRepository<Forum> ForumRepository
        {
            get
            {
                if (this._forumRepository == null)
                    this._forumRepository = new GenericRepository<Forum>(_context);
                return _forumRepository;
            }
        }

        public GenericRepository<Gamer> GamerRepository
        {
            get
            {
                if (this._gamerRepository == null)
                    this._gamerRepository = new GenericRepository<Gamer>(_context);
                return _gamerRepository;
            }
        }

        public GenericRepository<GroupChat> GroupChatRepository
        {
            get
            {
                if (this._groupChatRepository == null)
                    this._groupChatRepository = new GenericRepository<GroupChat>(_context);
                return _groupChatRepository;
            }
        }
        public GenericRepository<LynQAssLoad> LynQAssLoadRepository
        {
            get
            {
                if (this._lynQAssLoadRepository == null)
                    this._lynQAssLoadRepository = new GenericRepository<LynQAssLoad>(_context);
                return _lynQAssLoadRepository;
            }
        }
        
        public GenericRepository<LynQChatBlocker> LynQChatBlockerRepository
        {
            get
            {
                if (this._lynQChatBlockerRepository == null)
                    this._lynQChatBlockerRepository = new GenericRepository<LynQChatBlocker>(_context);
                return _lynQChatBlockerRepository;
            }
        }

        public GenericRepository<LynQChatBox> LynQChatBoxRepository
        {
            get
            {
                if (this._lynQChatBoxRepository == null)
                    this._lynQChatBoxRepository = new GenericRepository<LynQChatBox>(_context);
                return _lynQChatBoxRepository;
            }
        }

        public GenericRepository<LynQChatSetting> LynQChatSettingRepository
        {
            get
            {
                if (this._lynQChatSettingRepository == null)
                    this._lynQChatSettingRepository = new GenericRepository<LynQChatSetting>(_context);
                return _lynQChatSettingRepository;
            }
        }

        public GenericRepository<LynQComment> LynQCommentRepository
        {
            get
            {
                if (this._lynQCommentRepository == null)
                    this._lynQCommentRepository = new GenericRepository<LynQComment>(_context);
                return _lynQCommentRepository;
            }
        }

        public GenericRepository<LynQDepartment> LynQDepartmentRepository
        {
            get
            {
                if (this._lynQDepartmentRepository == null)
                    this._lynQDepartmentRepository = new GenericRepository<LynQDepartment>(_context);
                return _lynQDepartmentRepository;
            }
        }
        
        public GenericRepository<LynQderEvent> LynQderEventRepository
        {
            get
            {
                if (this._lynQderEventRepository == null)
                    this._lynQderEventRepository = new GenericRepository<LynQderEvent>(_context);
                return _lynQderEventRepository;
            }
        }

        public GenericRepository<LynQDocumentation> LynQDocumentationRepository
        {
            get
            {
                if (this._lynQDocumentationRepository == null)
                    this._lynQDocumentationRepository = new GenericRepository<LynQDocumentation>(_context);
                return _lynQDocumentationRepository;
            }
        }

        public GenericRepository<LynQer> LynQerRepository
        {
            get
            {
                if (this._lynQerRepository == null)
                    this._lynQerRepository = new GenericRepository<LynQer>(_context);
                return _lynQerRepository;
            }
        }
     
        public GenericRepository<LynQersComChat> LynQersComChatRepository
        {
            get
            {
                if (this._lynQersComChatRepository == null)
                    this._lynQersComChatRepository = new GenericRepository<LynQersComChat>(_context);
                return _lynQersComChatRepository;
            }
        }
        
        public GenericRepository<LynQForum> LynQForumRepository
        {
            get
            {
                if (this._lynQForumRepository == null)
                    this._lynQForumRepository = new GenericRepository<LynQForum>(_context);
                return _lynQForumRepository;
            }
        }
        
        public GenericRepository<LynQFriend> LynQFriendRepository
        {
            get
            {
                if (this._lynQFriendRepository == null)
                    this._lynQFriendRepository = new GenericRepository<LynQFriend>(_context);
                return _lynQFriendRepository;
            }
        }
        
        public GenericRepository<LynQGenTrailStu> LynQGenTrailStuRepository
        {
            get
            {
                if (this._lynQGenTrailStuRepository == null)
                    this._lynQGenTrailStuRepository = new GenericRepository<LynQGenTrailStu>(_context);
                return _lynQGenTrailStuRepository;
            }
        }

        public GenericRepository<LynQGrade> LynQGradeRepository
        {
            get
            {
                if (this._lynQGradeRepository == null)
                    this._lynQGradeRepository = new GenericRepository<LynQGrade>(_context);
                return _lynQGradeRepository;
            }
        }
        
        public GenericRepository<LynQGradeClass> LynQGradeClassRepository
        {
            get
            {
                if (this._lynQGradeClassRepository == null)
                    this._lynQGradeClassRepository = new GenericRepository<LynQGradeClass>(_context);
                return _lynQGradeClassRepository;
            }
        }
        
        public GenericRepository<LynQGroup> LynQGroupRepository
        {
            get
            {
                if (this._lynQGroupRepository == null)
                    this._lynQGroupRepository = new GenericRepository<LynQGroup>(_context);
                return _lynQGroupRepository;
            }
        }
        
        public GenericRepository<LynQGrpMem> LynQGrpMemRepository
        {
            get
            {
                if (this._lynQGrpMemRepository == null)
                    this._lynQGrpMemRepository = new GenericRepository<LynQGrpMem>(_context);
                return _lynQGrpMemRepository;
            }
        }
        
        public GenericRepository<LynQInfoBoard> LynQInfoBoardRepository
        {
            get
            {
                if (this._lynQInfoBoardRepository == null)
                    this._lynQInfoBoardRepository = new GenericRepository<LynQInfoBoard>(_context);
                return _lynQInfoBoardRepository;
            }
        }
        
        public GenericRepository<LynQLectAssignCode> LynQLectAssignCodeRepository
        {
            get
            {
                if (this._lynQLectAssignCodeRepository == null)
                    this._lynQLectAssignCodeRepository = new GenericRepository<LynQLectAssignCode>(_context);
                return _lynQLectAssignCodeRepository;
            }
        }
        
        public GenericRepository<LynQLectAssignElect> LynQLectAssignElectRepository
        {
            get
            {
                if (this._lynQLectAssignElectRepository == null)
                    this._lynQLectAssignElectRepository = new GenericRepository<LynQLectAssignElect>(_context);
                return _lynQLectAssignElectRepository;
            }
        }
        
        public GenericRepository<LynQLectAssignOptn> LynQLectAssignOptnRepository
        {
            get
            {
                if (this._lynQLectAssignOptnRepository == null)
                    this._lynQLectAssignOptnRepository = new GenericRepository<LynQLectAssignOptn>(_context);
                return _lynQLectAssignOptnRepository;
            }
        }
        
        public GenericRepository<LynQLoad> LynQLoadRepository
        {
            get
            {
                if (this._lynQLoadRepository == null)
                    this._lynQLoadRepository = new GenericRepository<LynQLoad>(_context);
                return _lynQLoadRepository;
            }
        }
        
        public GenericRepository<LynQLoadersTemp> LynQLoadersTempRepository
        {
            get
            {
                if (this._lynQLoadersTempRepository == null)
                    this._lynQLoadersTempRepository = new GenericRepository<LynQLoadersTemp>(_context);
                return _lynQLoadersTempRepository;
            }
        }
        
        public GenericRepository<LynQMajor> LynQMajorRepository
        {
            get
            {
                if (this._lynQMajorRepository == null)
                    this._lynQMajorRepository = new GenericRepository<LynQMajor>(_context);
                return _lynQMajorRepository;
            }
        }
        
        public GenericRepository<LynQMajorStu> LynQMajorStuRepository
        {
            get
            {
                if (this._lynQMajorStuRepository == null)
                    this._lynQMajorStuRepository = new GenericRepository<LynQMajorStu>(_context);
                return _lynQMajorStuRepository;
            }
        }
        
        public GenericRepository<LynQOfflineChat> LynQOfflineChatRepository
        {
            get
            {
                if (this._lynQOfflineChatRepository == null)
                    this._lynQOfflineChatRepository = new GenericRepository<LynQOfflineChat>(_context);
                return _lynQOfflineChatRepository;
            }
        }
        
        public GenericRepository<LynQPost> LynQPostRepository
        {
            get
            {
                if (this._lynQPostRepository == null)
                    this._lynQPostRepository = new GenericRepository<LynQPost>(_context);
                return _lynQPostRepository;
            }
        }
        
        public GenericRepository<LynQProgram> LynQProgramRepository
        {
            get
            {
                if (this._lynQProgramRepository == null)
                    this._lynQProgramRepository = new GenericRepository<LynQProgram>(_context);
                return _lynQProgramRepository;
            }
        }
        
        public GenericRepository<LynQQue> LynQQueRepository
        {
            get
            {
                if (this._lynQQueRepository == null)
                    this._lynQQueRepository = new GenericRepository<LynQQue>(_context);
                return _lynQQueRepository;
            }
        }
        
        public GenericRepository<LynQQueAn> LynQQueAnRepository
        {
            get
            {
                if (this._lynQQueAnRepository == null)
                    this._lynQQueAnRepository = new GenericRepository<LynQQueAn>(_context);
                return _lynQQueAnRepository;
            }
        }
        
        public GenericRepository<LynQQuiz> LynQQuizRepository
        {
            get
            {
                if (this._lynQQuizRepository == null)
                    this._lynQQuizRepository = new GenericRepository<LynQQuiz>(_context);
                return _lynQQuizRepository;
            }
        }
        
        public GenericRepository<LynQQuizAn> LynQQuizAnRepository
        {
            get
            {
                if (this._lynQQuizAnRepository == null)
                    this._lynQQuizAnRepository = new GenericRepository<LynQQuizAn>(_context);
                return _lynQQuizAnRepository;
            }
        }
        
        public GenericRepository<LynQQuizQue> LynQQuizQueRepository
        {
            get
            {
                if (this._lynQQuizQueRepository == null)
                    this._lynQQuizQueRepository = new GenericRepository<LynQQuizQue>(_context);
                return _lynQQuizQueRepository;
            }
        }
        
        public GenericRepository<LynQRequirement> LynQRequirementRepository
        {
            get
            {
                if (this._lynQRequirementRepository == null)
                    this._lynQRequirementRepository = new GenericRepository<LynQRequirement>(_context);
                return _lynQRequirementRepository;
            }
        }
        
        public GenericRepository<LynQRSVP> LynQRSVPRepository
        {
            get
            {
                if (this._lynQRSVPRepository == null)
                    this._lynQRSVPRepository = new GenericRepository<LynQRSVP>(_context);
                return _lynQRSVPRepository;
            }
        }
        
        public GenericRepository<LynQSchCalendar> LynQSchCalendarRepository
        {
            get
            {
                if (this._lynQSchCalendarRepository == null)
                    this._lynQSchCalendarRepository = new GenericRepository<LynQSchCalendar>(_context);
                return _lynQSchCalendarRepository;
            }
        }
        
        public GenericRepository<LynQSchool> LynQSchoolRepository
        {
            get
            {
                if (this._lynQSchoolRepository == null)
                    this._lynQSchoolRepository = new GenericRepository<LynQSchool>(_context);
                return _lynQSchoolRepository;
            }
        }
     
        public GenericRepository<LynQScoDetail> LynQScoDetailRepository
        {
            get
            {
                if (this._lynQScoDetailRepository == null)
                    this._lynQScoDetailRepository = new GenericRepository<LynQScoDetail>(_context);
                return _lynQScoDetailRepository;
            }
        }
        
        public GenericRepository<LynQScoMultiChoice> LynQScoMultiChoiceRepository
        {
            get
            {
                if (this._lynQScoMultiChoiceRepository == null)
                    this._lynQScoMultiChoiceRepository = new GenericRepository<LynQScoMultiChoice>(_context);
                return _lynQScoMultiChoiceRepository;
            }
        }
        
        public GenericRepository<LynQScore> LynQScoreRepository
        {
            get
            {
                if (this._lynQScoreRepository == null)
                    this._lynQScoreRepository = new GenericRepository<LynQScore>(_context);
                return _lynQScoreRepository;
            }
        }
        
        public GenericRepository<LynQScotion> LynQScotionRepository
        {
            get
            {
                if (this._lynQScotionRepository == null)
                    this._lynQScotionRepository = new GenericRepository<LynQScotion>(_context);
                return _lynQScotionRepository;
            }
        }
        
        public GenericRepository<LynQSubAssign> LynQSubAssignRepository
        {
            get
            {
                if (this._lynQSubAssignRepository == null)
                    this._lynQSubAssignRepository = new GenericRepository<LynQSubAssign>(_context);
                return _lynQSubAssignRepository;
            }
        }
        
        public GenericRepository<LynQTAd> LynQTAdRepository
        {
            get
            {
                if (this._lynQTAdRepository == null)
                    this._lynQTAdRepository = new GenericRepository<LynQTAd>(_context);
                return _lynQTAdRepository;
            }
        }
        
        public GenericRepository<LynQTradeChat> LynQTradeChatRepository
        {
            get
            {
                if (this._lynQTradeChatRepository == null)
                    this._lynQTradeChatRepository = new GenericRepository<LynQTradeChat>(_context);
                return _lynQTradeChatRepository;
            }
        }
        
        public GenericRepository<NGrade> NGradeRepository
        {
            get
            {
                if (this._nGradeRepository == null)
                    this._nGradeRepository = new GenericRepository<NGrade>(_context);
                return _nGradeRepository;
            }
        }
        
        public GenericRepository<NGrade_ProV> NGrade_ProVRepository
        {
            get
            {
                if (this._nGrade_ProVRepository == null)
                    this._nGrade_ProVRepository = new GenericRepository<NGrade_ProV>(_context);
                return _nGrade_ProVRepository;
            }
        }
        
        public GenericRepository<NRegistration> NRegistrationRepository
        {
            get
            {
                if (this._nRegistrationRepository == null)
                    this._nRegistrationRepository = new GenericRepository<NRegistration>(_context);
                return _nRegistrationRepository;
            }
        }
        
        public GenericRepository<Skulz> SkulzRepository
        {
            get
            {
                if (this._skulzRepository == null)
                    this._skulzRepository = new GenericRepository<Skulz>(_context);
                return _skulzRepository;
            }
        }
        
        public GenericRepository<Status> StatusRepository
        {
            get
            {
                if (this._statusRepository == null)
                    this._statusRepository = new GenericRepository<Status>(_context);
                return _statusRepository;
            }
        }
        
        public GenericRepository<Tag> TagRepository
        {
            get
            {
                if (this._tagRepository == null)
                    this._tagRepository = new GenericRepository<Tag>(_context);
                return _tagRepository;
            }
        }
       
        public GenericRepository<Trail_List> Trail_ListRepository
        {
            get
            {
                if (this._trail_ListRepository == null)
                    this._trail_ListRepository = new GenericRepository<Trail_List>(_context);
                return _trail_ListRepository;
            }
        }
        
        public GenericRepository<UChat> UChatRepository
        {
            get
            {
                if (this._uChatRepository == null)
                    this._uChatRepository = new GenericRepository<UChat>(_context);
                return _uChatRepository;
            }
        }
        
        public GenericRepository<UqCoding> UqCodingRepository
        {
            get
            {
                if (this._uqCodingRepository == null)
                    this._uqCodingRepository = new GenericRepository<UqCoding>(_context);
                return _uqCodingRepository;
            }
        }
        
        public GenericRepository<UqTimeLine> UqTimeLineRepository
        {
            get
            {
                if (this._uqTimeLineRepository == null)
                    this._uqTimeLineRepository = new GenericRepository<UqTimeLine>(_context);
                return _uqTimeLineRepository;
            }
        }
        
        public GenericRepository<Why> WhyRepository
        {
            get
            {
                if (this._whyRepository == null)
                    this._whyRepository = new GenericRepository<Why>(_context);
                return _whyRepository;
            }
        }
        #endregion

        #region Public member methods...
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDisposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
