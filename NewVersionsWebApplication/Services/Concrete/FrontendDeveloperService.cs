using NewVersionsWebApplication.Services.Abstract;

namespace NewVersionsWebApplication.Services.Concrete
{
    public class FrontendDeveloperService : IDeveloperService
    {
        public string GetDeveloperType => "Frontend Developer";
    }
}
