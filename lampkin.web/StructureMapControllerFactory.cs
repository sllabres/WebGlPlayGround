using System;
using System.Collections.Generic;
using System.Web.Mvc;
using StructureMap;
using Lampkin.Web.Controllers;

namespace Lampkin.Web
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            try
            {
                if(controllerType == null)
                    return ObjectFactory.GetInstance<HomeController>();
                else
                    return ObjectFactory.GetInstance(controllerType) as Controller;
            }
            catch (StructureMapException)
            {
                System.Diagnostics.Debug.WriteLine(ObjectFactory.WhatDoIHave());
                throw;
            }            
        }
    }
}
