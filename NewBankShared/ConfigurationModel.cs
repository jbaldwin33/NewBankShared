﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewBankShared
{
  public class ConfigurationModel
  {
    public bool LocalConnection { get; set; }
    public string Endpoint { get; set; }
    public int Port { get; set; }
  }
}
