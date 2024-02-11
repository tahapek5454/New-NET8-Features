using NewVersionsWebApplication.Services.Abstract;

namespace NewVersionsWebApplication.Services.Concrete
{
    public class BackendDeveloperService : IDeveloperService
    {
        public string GetDeveloperType => "Backend Developer";
    }
}
