using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface IGenericDevice
    {
        [DispId(1)]
        int AddAccessRightToUser(string sUserId, int iRemoteGroupId, int iTimeGroupId);
        [DispId(2)]
        int Cancel();
        [DispId(3)]
        int CaptureRealTimeImages(int imageType);
        [DispId(36)]
        int CheckDuplicateIris(int iEye, object byaRightIrisCode, object byaLeftIrisCode, out string sUserId);
        [DispId(4)]
        int ConnectToCam(string sCamIP, string sSerialNumber);
        [DispId(5)]
        int ConnectToServer(string sServerIP, string sSecurityId, string sOperatorId, string sPassword);
        [DispId(6)]
        int CreateIrisCode(int iEye, int iTimeout, int iReqdQuality, out object ICRight, out int iREQuality, out object ICLeft, out int iLEQuality);
        [DispId(7)]
        int DeleteAccessRightFromUser(string sUserId, int iRemoteGroupId, int iTimeGroupId);
        [DispId(8)]
        int DeleteUser(string sUserId);
        [DispId(9)]
        int DisconnectCam();
        [DispId(10)]
        int DisconnectServer();
        [DispId(11)]
        int EnrollUser(string sUserId, int iEye, string sFirstName, string sMiddleName, string sLastName, int iSex, string sDept, int iPin, int iCardType, string sCardId, string sCardNumber, object irisCodeR, object irisCodeL, out string sExistingUserId);
        [DispId(12)]
        int GetAccessRight(string sUserId, int iIndex, out int iRemoteGroupId, out string sRemoteGroupName, out string sRemoteGroupDesc, out int iTimeGroupId, out string sTimeGroupName, out string sTimeGroupDesc);
        [DispId(13)]
        int GetAccessRightNumber(string sUserId, out int iNumber);
        [DispId(14)]
        int GetCamAngle(out int iAngle);
        [DispId(15)]
        int GetExtendedError();
        [DispId(16)]
        int GetFacePicture(string sUserId, out object facePicture, out int iPictureSize);
        [DispId(17)]
        int GetFakeEyeDetection(out int iActive);
        [DispId(18)]
        int GetGroup(int iGroupType, int index, out int iGroupId, out string strGroupName, out string strGroupDescription);
        [DispId(19)]
        int GetGroupNumber(int iGroupType, out int iGroupNum);
        [DispId(20)]
        int GetIrisCodeFromServer(string sUserId, int iWhichEye, out object irisCodeR, out object irisCodeL);
        [DispId(21)]
        int GetUserInfo(string sUserId, out int iEye, out string sFirstName, out string sMiddleName, out string sLastName, out int iSex, out string sDepartment, out int iPin, out int iCardType, out string sCardId, out string sCardNumber, out string sPosition, out string sResidentNumber, out string sAddress, out string sOfficePhone, out string sHomePhone, out string sMobilePhone, out string sEmail, out string sMemo1, out string sMemo2, out string sMemo3, out string sMemo4, out string sMemo5);
        [DispId(22)]
        int GetVolume(out int iVolume);
        [DispId(23)]
        int IdentifyUser(int iEye, int iTimeout, out string sUserId);
        [DispId(24)]
        bool IsCamConnected();
        [DispId(25)]
        bool IsServerConnected();
        [DispId(26)]
        int ModifyUser(string sUserId, string sFirstName, string sMiddleName, string sLastName, int iSex, string sDepartment, int iPin, int iCardType, string sCardId, string sCardNumber, string sPosition, string sResidentNumber, string sAddress, string sOfficePhone, string sHomePhone, string sMobilePhone, string sEmail, string sMemo1, string sMemo2, string sMemo3, string sMemo4, string sMemo5);
        [DispId(27)]
        int SetCamAngle(int iAngle);
        [DispId(28)]
        int SetFacePicture(string sUserId, object facePicture, int iPictureSize);
        [DispId(29)]
        int SetFakeEyeDetection(int iActive);
        [DispId(30)]
        int SetVfd(string sMessage);
        [DispId(31)]
        int SetVolume(int iVolume);
        [DispId(32)]
        int StopRealTimeImages();
        [DispId(33)]
        int VerifyIrisCode(int iEye, int iTimeout, object ICRight, object ICLeft);
        [DispId(34)]
        int VerifyUser(string sUserId, int iEye, int iTimeout);
        [DispId(35)]
        int VerifyUserByPin(int iEye, int iTimeout);

        void Dispose();
    }
}
