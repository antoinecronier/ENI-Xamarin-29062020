﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tp6.Entities
{
    public class User
{
		private String login;
		private String password;

		public String Login
		{
			get { return login; }
			set { login = value; }
		}

		public String Password
		{
			get { return password; }
			set { password = value; }
		}
	}
}
