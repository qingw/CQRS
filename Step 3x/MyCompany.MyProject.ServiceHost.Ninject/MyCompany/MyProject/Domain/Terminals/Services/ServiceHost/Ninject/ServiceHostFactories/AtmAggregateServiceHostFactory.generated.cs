﻿










//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using MyCompany.MyProject.Domain.Terminals.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Cqrs.Ninject.ServiceHost;
using MyCompany.MyProject.Domain.Terminals.Services;

namespace MyCompany.MyProject.Domain.Terminals.Services.ServiceHost.Ninject.ServiceHostFactories
{
	/// <summary>
	/// A <see cref="NinjectWcfServiceHostFactory{TServiceType}"/> for using  <see cref="IAtmService"/> via WCF
	/// </summary>
	[GeneratedCode("CQRS UML Code Generator", "1.601.786")]
	public partial class AtmServiceHostFactory : NinjectWcfServiceHostFactory<IAtmService>
	{
	}

}
