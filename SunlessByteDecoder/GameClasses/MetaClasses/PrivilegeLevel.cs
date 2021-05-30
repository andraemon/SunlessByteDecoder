using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.MetaClasses
{
    internal enum PrivilegeLevel
    {
		Banned = -1,
		User,
		Contributor,
		Author = 5,
		Editor = 7,
		Owner,
		Developer = 10,
		Admin = 99,
		God = 100000000
	}
}
