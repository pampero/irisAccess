using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Implementations
{
    public class INulDeviceService : IGenericDevice
    {
        public int AddAccessRightToUser(string sUserId, int iRemoteGroupId, int iTimeGroupId)
        {
            throw new NotImplementedException();
        }

        public int Cancel()
        {
            throw new NotImplementedException();
        }

        public int CaptureRealTimeImages(int imageType)
        {
            throw new NotImplementedException();
        }

        public int CheckDuplicateIris(int iEye, object byaRightIrisCode, object byaLeftIrisCode, out string sUserId)
        {
            throw new NotImplementedException();
        }

        public int ConnectToCam(string sCamIP, string sSerialNumber)
        {
            throw new NotImplementedException();
        }

        public int ConnectToServer(string sServerIP, string sSecurityId, string sOperatorId, string sPassword)
        {
            throw new NotImplementedException();
        }

        public int CreateIrisCode(int iEye, int iTimeout, int iReqdQuality, out object ICRight, out int iREQuality, out object ICLeft, out int iLEQuality)
        {
            throw new NotImplementedException();
        }

        public int DeleteAccessRightFromUser(string sUserId, int iRemoteGroupId, int iTimeGroupId)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(string sUserId)
        {
            throw new NotImplementedException();
        }

        public int DisconnectCam()
        {
            throw new NotImplementedException();
        }

        public int DisconnectServer()
        {
            throw new NotImplementedException();
        }

        public int EnrollUser(string sUserId, int iEye, string sFirstName, string sMiddleName, string sLastName, int iSex, string sDept, int iPin, int iCardType, string sCardId, string sCardNumber, object irisCodeR, object irisCodeL, out string sExistingUserId)
        {
            throw new NotImplementedException();
        }

        public int GetAccessRight(string sUserId, int iIndex, out int iRemoteGroupId, out string sRemoteGroupName, out string sRemoteGroupDesc, out int iTimeGroupId, out string sTimeGroupName, out string sTimeGroupDesc)
        {
            throw new NotImplementedException();
        }

        public int GetAccessRightNumber(string sUserId, out int iNumber)
        {
            throw new NotImplementedException();
        }

        public int GetCamAngle(out int iAngle)
        {
            throw new NotImplementedException();
        }

        public int GetExtendedError()
        {
            throw new NotImplementedException();
        }

        public int GetFacePicture(string sUserId, out object facePicture, out int iPictureSize)
        {
            throw new NotImplementedException();
        }

        public int GetFakeEyeDetection(out int iActive)
        {
            throw new NotImplementedException();
        }

        public int GetGroup(int iGroupType, int index, out int iGroupId, out string strGroupName, out string strGroupDescription)
        {
            throw new NotImplementedException();
        }

        public int GetGroupNumber(int iGroupType, out int iGroupNum)
        {
            throw new NotImplementedException();
        }

        public int GetIrisCodeFromServer(string sUserId, int iWhichEye, out object irisCodeR, out object irisCodeL)
        {
            throw new NotImplementedException();
        }

        public int GetUserInfo(string sUserId, out int iEye, out string sFirstName, out string sMiddleName, out string sLastName, out int iSex, out string sDepartment, out int iPin, out int iCardType, out string sCardId, out string sCardNumber, out string sPosition, out string sResidentNumber, out string sAddress, out string sOfficePhone, out string sHomePhone, out string sMobilePhone, out string sEmail, out string sMemo1, out string sMemo2, out string sMemo3, out string sMemo4, out string sMemo5)
        {
            throw new NotImplementedException();
        }

        public int GetVolume(out int iVolume)
        {
            throw new NotImplementedException();
        }

        public int IdentifyUser(int iEye, int iTimeout, out string sUserId)
        {
            throw new NotImplementedException();
        }

        public bool IsCamConnected()
        {
            throw new NotImplementedException();
        }

        public bool IsServerConnected()
        {
            throw new NotImplementedException();
        }

        public int ModifyUser(string sUserId, string sFirstName, string sMiddleName, string sLastName, int iSex, string sDepartment, int iPin, int iCardType, string sCardId, string sCardNumber, string sPosition, string sResidentNumber, string sAddress, string sOfficePhone, string sHomePhone, string sMobilePhone, string sEmail, string sMemo1, string sMemo2, string sMemo3, string sMemo4, string sMemo5)
        {
            throw new NotImplementedException();
        }

        public int SetCamAngle(int iAngle)
        {
            throw new NotImplementedException();
        }

        public int SetFacePicture(string sUserId, object facePicture, int iPictureSize)
        {
            throw new NotImplementedException();
        }

        public int SetFakeEyeDetection(int iActive)
        {
            throw new NotImplementedException();
        }

        public int SetVfd(string sMessage)
        {
            throw new NotImplementedException();
        }

        public int SetVolume(int iVolume)
        {
            throw new NotImplementedException();
        }

        public int StopRealTimeImages()
        {
            throw new NotImplementedException();
        }

        public int VerifyIrisCode(int iEye, int iTimeout, object ICRight, object ICLeft)
        {
            throw new NotImplementedException();
        }

        public int VerifyUser(string sUserId, int iEye, int iTimeout)
        {
            throw new NotImplementedException();
        }

        public int VerifyUserByPin(int iEye, int iTimeout)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
