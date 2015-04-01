﻿using System;
using System.Runtime.Serialization;
using Cqrs.Domain;

namespace Cqrs.Commands
{
	/// <summary>
	/// A <see cref="ICommand{TPermissionToken}"/> for <see cref="IDto"/> objects
	/// </summary>
	public class DtoCommand<TAuthenticationToken, TDto> : ICommand<TAuthenticationToken>
		where TDto : IDto
	{
		[DataMember]
		public TDto Original { get; set; }

		[DataMember]
		public TDto New { get; set; }

		public DtoCommand(Guid id, TDto original, TDto @new)
		{
			Id = id;
			Original = original;
			New = @new;
		}

		[DataMember]
		public Guid Id { get; set; }

		[DataMember]
		public int ExpectedVersion { get; set; }

		#region Implementation of IMessageWithAuthenticationToken<TAuthenticationToken>

		[DataMember]
		public TAuthenticationToken AuthenticationToken { get; set; }

		#endregion

		#region Implementation of IMessage

		[DataMember]
		public Guid CorrolationId { get; set; }

		#endregion
	}
}