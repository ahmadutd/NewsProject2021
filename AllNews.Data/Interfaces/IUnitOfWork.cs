using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository catageryRepo { get; }
        INewsRepository newsRepo { get; }
        IPhotoRepository photoRepo { get; }
        IVideosRepository videoRepo { get; }
        IAudioRepository audioRepo { get; }
        IStatementRepository statementRepo { get; }
        IPaperRepository paperRepo { get; }
        IStudiesRepository studiesRepo { get; }
        ICompanyRepository companyRepo { get; }
        ITagRepository tagRepo { get; }
        IMoveTextRepository movetextRepo { get; }
        INewsTagRepository newstagRepo { get; }
        IVideoTagRepository videotagRepo { get; }
        IPhotoTagRepository phototagRepo { get; }
        ILanguageRepository langRepo { get; }
        ISocialManagmentRepository socialManagmentRepo { get; }
        IAppRoleRepository appRoleRepo { get; }
        IAppUserRepository appUserRepo { get; }
        IAppRoleUserRepository appRoleUserRepo { get; }

        int Commit();
    }
}
