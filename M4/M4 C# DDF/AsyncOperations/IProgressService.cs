/* WARNING! This program and source code is owned and licensed by 
   Modulus Financial Engineering, Inc. http://www.modulusfe.com
   Viewing or use this code requires your acceptance of the license
   agreement found at http://www.modulusfe.com/support/license.pdf
   Removal of this comment is a violation of the license agreement.
   Copyright 2007-2010 by Modulus Financial Engineering, Inc. */

namespace M4.AsyncOperations
{
	interface IProgressService
	{
		IProgressVisualizer CreateVisualizer(ProgressWorkerParams workerParams);
	}
}
