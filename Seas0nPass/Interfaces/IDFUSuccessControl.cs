﻿////
//
//  Seas0nPass
//
//  Copyright 2011 FireCore, LLC. All rights reserved.
//  http://firecore.com
//
////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seas0nPass.Interfaces
{
    public interface IDFUSuccessControl : IView
    {
        event EventHandler ButtonClicked;
        void SetFileName(string fileName);
    }
}