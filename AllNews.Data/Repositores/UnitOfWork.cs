using AllNews.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AllNewsDbContext _context;
        public UnitOfWork(AllNewsDbContext context)
        {
            _context = context;
        }
        private readonly ICategoryRepository _catageryRepo;
        public ICategoryRepository catageryRepo
        {
            get
            {
                if (_catageryRepo == null)
                    return new CategoryRepository(_context);
                return _catageryRepo;
            }
        }
        private readonly INewsRepository _newsRepo;
        public INewsRepository newsRepo
        {
            get
            {
                if (_newsRepo == null)
                    return new NewsRepository(_context);
                return _newsRepo;
            }
        }

        private readonly IPhotoRepository _photoRepo;
        public IPhotoRepository photoRepo
        {
            get
            {
                if (_photoRepo == null)
                    return new PhotoRepository(_context);
                return _photoRepo;
            }
        }

        private readonly IVideosRepository _videoRepo;
        public IVideosRepository videoRepo
        {
            get
            {
                if (_videoRepo == null)
                    return new VideosRepository(_context);
                return _videoRepo;
            }
        }

        private readonly IAudioRepository _audioRepo;
        public IAudioRepository audioRepo
        {
            get
            {
                if (_audioRepo == null)
                    return new AudioRepository(_context);
                return _audioRepo;
            }
        }

        private readonly IStatementRepository _statementRepo;
        public IStatementRepository statementRepo
        {
            get
            {
                if (_statementRepo == null)
                    return new StatementRepository(_context);
                return _statementRepo;
            }
        }

        private readonly IPaperRepository _paperRepo;
        public IPaperRepository paperRepo
        {
            get
            {
                if (_paperRepo == null)
                    return new PaperRepository(_context);
                return _paperRepo;
            }
        }
        private readonly IStudiesRepository _studiesRepo;
        public IStudiesRepository studiesRepo
        {
            get
            {
                if (_studiesRepo == null)
                    return new StudiesRepository(_context);
                return _studiesRepo;
            }
        }
        private readonly ICompanyRepository _companyRepo;
        public ICompanyRepository companyRepo
        {
            get
            {
                if (_companyRepo == null)
                    return new CompanyRepository(_context);
                return _companyRepo;
            }
        }

        private readonly ITagRepository _tagRepo;
        public ITagRepository tagRepo
        {
            get
            {
                if (_tagRepo == null)
                    return new TagRepository(_context);
                return _tagRepo;
            }
        }
        private readonly INewsTagRepository _newstagRepo;
        public INewsTagRepository newstagRepo
        {
            get
            {
                if (_newstagRepo == null)
                    return new NewsTagRepository(_context);
                return _newstagRepo;
            }
        }
        private readonly IVideoTagRepository _videotagRepo;
        public IVideoTagRepository videotagRepo
        {
            get
            {
                if (_videotagRepo == null)
                    return new VideoTagRepository(_context);
                return _videotagRepo;
            }
        }

        private readonly IMoveTextRepository _movetextRepo;
        public IMoveTextRepository movetextRepo
        {
            get
            {
                if (_movetextRepo == null)
                    return new MoveTextRepository(_context);
                return _movetextRepo;
            }
        }
        private readonly ILanguageRepository _langRepo;
        public ILanguageRepository langRepo
        {
            get
            {
                if (_langRepo == null)
                    return new LanguageRepository(_context);
                return _langRepo;
            }
        }

        private readonly IPhotoTagRepository _phototagRepo;
        public IPhotoTagRepository phototagRepo
        {
            get
            {
                if (_phototagRepo == null)
                    return new PhotoTagRipository(_context);
                return _phototagRepo;
            }
        }
        private readonly ISocialManagmentRepository _socialManagmentRepo;
        public ISocialManagmentRepository socialManagmentRepo
        {
            get
            {
                if (_socialManagmentRepo == null)
                    return new SocialManagmentRepository(_context);
                return _socialManagmentRepo;
            }
        }

        private readonly IAppRoleRepository _appRoleRepo;
        public IAppRoleRepository appRoleRepo
        {
            get
            {
                if (_appRoleRepo == null)
                    return new AppRoleRepository(_context);
                return _appRoleRepo;
            }
        }
        private readonly IAppUserRepository _appUserRepo;
        public IAppUserRepository appUserRepo
        {
            get
            {
                if (_appUserRepo == null)
                    return new AppUserRepository(_context);
                return _appUserRepo;
            }
        }
        private readonly IAppRoleUserRepository _appRoleUserRepo;
        public IAppRoleUserRepository appRoleUserRepo
        {
            get
            {
                if (_appRoleUserRepo == null)
                    return new AppRoleUserRepository(_context);
                return _appRoleUserRepo;
            }
        }
        private readonly IAboutRepository _aboutRepo;
        public IAboutRepository aboutRepo
        {
            get
            {
                if (_aboutRepo == null)
                    return new AboutRepository(_context);
                return _aboutRepo;
            }
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
