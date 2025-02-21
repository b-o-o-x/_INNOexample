//================================================================================
//
// _INNO._Custom.CustomIni
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2025-01-04
//--------------------------------------------------------------------------------
// [설명]
// 1. 고객맞춤 Ini 제어 클래스 (SetSection()으로 섹션 미리 지정)
//--------------------------------------------------------------------------------
// [이력]
// <날짜>    <작성자>    <설명>
// 25-01-04  Andy Yang	Initial.
//================================================================================
//
using _INNO._File;
using System.IO;

namespace _INNO._Custom
{
    /// <summary>
    /// CustomIni 클래스
    /// [사용방법]
    /// <code>
    /// CustomIni ini = new CustomIni();
    /// ini.
    /// </code>
    /// </summary>
    public class CustomIni
    {
        string _fullPath = "";
        string _section = "";

        /// <summary>
        /// 생성자
        /// </summary>
        public CustomIni(string fullPath)
        {
            _fullPath = fullPath;
        }

        /// <summary>
        /// Ini 파일 경로 설정 (D:\Config\Config.ini와 같이 파일을 포함한 전체 경로 설정)
        /// </summary>
        /// <param name="fullPath"></param>
        public void SetPath(string fullPath)
        {
            _fullPath = fullPath;
        }

        /// <summary>
        /// 섹션 설정
        /// </summary>
        /// <param name="section"></param>
        public void SetSection(string section)
        {
            _section = section;
        }

        /// <summary>
        /// 섹션 얻기
        /// </summary>
        public string GetSection()
        {
            return _section;
        }

        /// <summary>
        /// 섹션 초기화
        /// </summary>
        public void ClearSection()
        {
            _section = "";
        }

        /// <summary>
        /// 문자열 쓰기
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void WriteString(string key, string value)
        {
            InnoIni._WriteFullString(_section, key, value, _fullPath);
        }

        /// <summary>
        /// 문자열 읽기
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public string ReadString(string key, string defaultValue = "")
        {
            return InnoIni._ReadFullString(_section, key, _fullPath, defaultValue);
        }
    }
}
