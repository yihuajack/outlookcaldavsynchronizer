﻿// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using CalDavSynchronizer.Contracts;

namespace CalDavSynchronizer.Ui
{
  public class AdvancedOptions
  {
    private readonly bool _closeConnectionAfterEachRequest;
    private readonly ProxyOptions _proxyOptions;

    public AdvancedOptions (bool closeConnectionAfterEachRequest, ProxyOptions proxyOptions)
    {
      if (proxyOptions == null)
        throw new ArgumentNullException ("proxyOptions");

      _closeConnectionAfterEachRequest = closeConnectionAfterEachRequest;
      _proxyOptions = proxyOptions;
    }

    public bool CloseConnectionAfterEachRequest
    {
      get { return _closeConnectionAfterEachRequest; }
    }

    public ProxyOptions ProxyOptions
    {
      get { return _proxyOptions; }
    }
  }
}