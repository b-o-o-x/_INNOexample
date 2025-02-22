//================================================================================
//
// _INNO._Data.CustomCodeTrackerIni
//
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2019-08-01
//--------------------------------------------------------------------------------
// [설명]
// 1. 고객맞춤 Code 기반 데이터 Tracking 클래스
//--------------------------------------------------------------------------------
// [이력]
// <날짜>   <작성자>    <설명>
// 19-08-01 Andy Yang  Initial.
// 25-01-27 Andy Yang  OK, NG 관련 좀더 심플하고 명확하게 보완 수정
//================================================================================
//
using _INNO._File;
using System;

namespace _INNO._Custom
{
    /// <summary>
    /// CustomCodeTrackerIni 클래스
    /// </summary>
    public class CustomCodeTrackerIni : _Data.InnoCodeManagerIni
    {
        const string SECTION = "DATA";

        /// <summary>
        /// 생성자
        /// </summary>
        public CustomCodeTrackerIni()
        {
            SetRootFolder(@".\_Data\CustomCodeTrackerIni");
        }

        /// <summary>
        /// /ROOT/년/년월/년월일/Code.ini 파일이 없으면 생성하고, 있으면 업데이트합니다.
        /// </summary>
        /// <param name="code"></param>
        private void UpdateCodeFile(string code)
        {
            code = this.GetUseCleanCode() ? GetCleanCode(code) : code;
            if (code == String.Empty) return;

            // /CodeTracking/yyyy/yyyyMM/yyyyMMdd/[code].ini 파일 생성
            string codeFile = GetCodeFile(code);

            if (InnoIni._ReadString(SECTION, "CODE", codeFile).IsNullOrEmpty()) // 비어있으면 코드 쓰기
                InnoIni._WriteString(SECTION, "CODE", code, codeFile);
            if (InnoIni._ReadString(SECTION, "CODE_FILE_CREATE_DATE", codeFile).IsNullOrEmpty()) // 비어있으면 생성날짜 쓰기
                InnoIni._WriteString(SECTION, "CODE_FILE_CREATE_DATE", Inno._GetNowFormatString(), codeFile);
            InnoIni._WriteString(SECTION, "CODE_FILE_LAST_ACCESS_DATE", Inno._GetNowFormatString(), codeFile);
        }

        /// <summary>
        /// Code.ini의 TRACK_OK를 OK로 설정 시도합니다.<br/>
        /// 1) 기존 정보가 없거나 OK인 경우, OK로 설정됩니다.<br/>
        /// 2) 기존 NG인 경우 OK로 설정되지 않습니다.<br/>
        /// 3) 강제로 OK 처리를 하려면 forceOK=true를 사용하세요.<br/>
        /// </summary>
        /// <param name="code"></param>
        /// <param name="forceOK">강제 OK 처리</param>
        public void SetTrackOK(string code, bool forceOK = false)
        {
            UpdateCodeFile(code);

            string codeFile = GetCodeFile(code);

            string trackOkText = InnoIni._ReadString(SECTION, "TRACK_OK", codeFile);
            bool trackOkBool = InnoIni._ReadBool(SECTION, "TRACK_OK", codeFile);

            if (trackOkText.IsNullOrWhiteSpace() || trackOkBool || forceOK) // None(비어있거나), OK 상태였거나, forceOK 라면 true로 설정
                InnoIni._WriteBool(SECTION, "TRACK_OK", true, codeFile);
            //else
            //    InnoIni._WriteBool(SECTION, "TRACK_OK", false, codeFile);

            // TRACK_OK KEY가 존재하지 않으면, OK로 처리.
            // - accText 값이 없으면 OK/NG가 아니므로, lastOK를 기본 true로 가져오고,
            // - accText 값이 있으면 OK 또는 NG일 것으로 추정하고, lastOK를 기본 false로 가져오도록 함.
            //string accText = InnoIni._ReadString(SECTION, "TRACK_OK", codeFile);
            //bool lastOK = InnoIni._ReadBool(SECTION, "TRACK_OK", codeFile, (accText == string.Empty ? true : false));
            //if (forceOK) lastOK = true;
            //InnoIni._WriteBool(SECTION, "TRACK_OK", lastOK, codeFile);
        }

        /// <summary>
        /// Code.ini의 TRACK_OK를 NG로 설정합니다.
        /// </summary>
        /// <param name="code"></param>
        public void SetTrackNG(string code)
        {
            UpdateCodeFile(code);
            InnoIni._WriteBool(SECTION, "TRACK_OK", false, GetCodeFile(code));
        }

        /// <summary>
        /// Code.ini의 TRACK_OK를 None 상태로 설정합니다.
        /// </summary>
        /// <param name="code"></param>
        public void SetTrackNone(string code)
        {
            InnoIni._WriteString(SECTION, "TRACK_OK", "", GetCodeFile(code));
        }

        /// <summary>
        /// TRACK_OK의 OK 여부를 리턴합니다.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsTrackOK(string code)
        {
            string codeFile = GetCodeFile(code);

            // None 상태라면 OK가 아니므로 false 리턴..
            string trackOkText = InnoIni._ReadString(SECTION, "TRACK_OK", codeFile);
            if (trackOkText.IsNullOrWhiteSpace()) return false;

            return InnoIni._ReadBool(SECTION, "TRACK_OK", codeFile);
        }

        /// <summary>
        /// TRACK_OK의 NG 여부를 리턴합니다.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsTrackNG(string code)
        {
            string codeFile = GetCodeFile(code);

            // None 상태라면 NG가 아니므로 false 리턴..
            string trackOkText = InnoIni._ReadString(SECTION, "TRACK_OK", codeFile);
            if (trackOkText.IsNullOrWhiteSpace()) return false;

            return !InnoIni._ReadBool(SECTION, "TRACK_OK", codeFile);
        }

        /// <summary>
        /// TRACK_OK의 None 여부를 리턴합니다.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsTrackNone(string code)
        {
            string codeFile = GetCodeFile(code);

            bool ret = false;
            string trackOkText = InnoIni._ReadString(SECTION, "TRACK_OK", codeFile);
            if (trackOkText.IsNullOrWhiteSpace()) ret = true; // 비어있다면 None 상태이므로 true
            return ret;
        }
    }
}
