// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright � 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

using System;
using DvtkHighLevelInterface.Dicom.Threads;
using DvtkHighLevelInterface.Common.UserInterfaces;
using Dvtk.DvtkDicomEmulators.Bases;
using Dvtk.DvtkDicomEmulators.PrintMessageHandlers;

namespace Dvtk.DvtkDicomEmulators.PrintClientServers
{
    /// <summary>
    /// Summary description for PrintScp.
    /// </summary>
    public class PrintScp : HliScp
    {
        /// <summary>
        /// Class Constructor.
        /// </summary>
        public PrintScp() : base()
        {
            // Do nothing.
        }

        /// <summary>
        /// Add the default message handlers.
        /// </summary>
        public void AddDefaultMessageHandlers()
        {
            PrintContext printContext = new PrintContext();
            AddToBack(new NActionHandler(printContext));
            AddToBack(new NCreateHandler(printContext));
            AddToBack(new NDeleteHandler(printContext));
            AddToBack(new NGetHandler(printContext));
            AddToBack(new NSetHandler(printContext));
        }
    }
}
