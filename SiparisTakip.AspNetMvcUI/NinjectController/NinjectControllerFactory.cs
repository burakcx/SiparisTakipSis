using Ninject;
using SiparisTakip.BLL.FaturaBLL;
using SiparisTakip.BLL.KullaniciBLL;
using SiparisTakip.BLL.StokBLL;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Interfaces.FaturaIG;
using SiparisTakip.Interfaces.KullaniciIG;
using SiparisTakip.Interfaces.StokIG;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace SiparisTakip.AspNetMvcUI.NinjectController
{
    public class NinjectControllerFactory: DefaultControllerFactory
    {
        private readonly IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBllBindings();
        }
        private void AddBllBindings()
        {
            ninjectKernel.Bind<IKullaniciService>()
                .To<KullaniciManager>()
                .WithConstructorArgument("IKullaniciDal", 
                new EFKullaniciRepository());

            ninjectKernel.Bind<IStokService>()
                .To<StokManager>()
                .WithConstructorArgument("IStokDal", 
                new EFStokRepository());

            ninjectKernel.Bind<IFaturaService>()
                .To<FaturaManager>()
                .WithConstructorArgument("IFaturaDal", 
                new EFFaturaRepository());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}