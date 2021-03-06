using System;

namespace Avgangsalarm.Core.Services
{
	public interface ILog
	{
		void Info(string format, params object[] args);

		void Warn(string format, params object[] args);

		void Error(Exception exception);
	}
}

