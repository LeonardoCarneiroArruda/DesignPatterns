using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facades
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get => facade;
        }


    }
}
