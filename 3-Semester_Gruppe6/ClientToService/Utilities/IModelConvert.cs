﻿using ClientToService.ModelLayer;
using ClientToService.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientToService.Utilities
{
       public interface IModelConvert
       {
            void ConvertToServiceAuction(Auction auction);
            
       }
}
