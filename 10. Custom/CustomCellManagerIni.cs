//================================================================================
//
// _INNO._Custom.CustomCellManagerIni
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2025-01-25
//--------------------------------------------------------------------------------
// [설명]
// 1. 고객맞춤 Cell ID 기반 Cell Ini 데이터 관리 클래스
//--------------------------------------------------------------------------------
// [이력]
// <날짜>    <작성자>    <설명>
// 25-01-25  Andy Yang	Initial.
// 25-01-27  Andy Yang  CustomCellTrackerIni => CustomCellManagerIni
//================================================================================
//
using _INNO;
using _INNO._Data;
using _INNO._File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _INNO._Custom
{
    // 섹션명 고정, 폴더 고정, 프로퍼티 사용을 통해 통일성 강화 및 오류 확률을 줄이고, 좀더 안전한 접근이 가능해지도록 구성하였습니다.

    public class CustomCellManagerIni : InnoCodeManagerIni
    {
        const string SECTION = "CELL";

        public CustomCellManagerIni()
        {
            this.SetRootFolder(@".\_Data\CustomCellManagerIni");
            this.SetSubFolder("CELL");
        }

        public CustomCellManagerIni(string cellID) : this()
        {
            this.SetCode(cellID);
        }

        new public string SetCode(string cellID)
        {
            base.SetCode(cellID);
            this.ID = cellID;
            if (this.DATETIME_CREATE.IsNullOrEmpty()) this.DATETIME_CREATE = Inno._GetNowFormatString();
            this.DATETIME_LAST = Inno._GetNowFormatString();
            return base.CodeFile;
        }

        public string ID
        {
            get { return this[this.Code][SECTION][Inno._GetPropertyName()].ToString(); }
            set { this[this.Code][SECTION][Inno._GetPropertyName()] = value; }
        }
        public string DATETIME_CREATE
        {
            get { return this[this.Code][SECTION][Inno._GetPropertyName()].ToString(); }
            set { this[this.Code][SECTION][Inno._GetPropertyName()] = value; }
        }
        public string DATETIME_LAST
        {
            get { return this[this.Code][SECTION][Inno._GetPropertyName()].ToString(); }
            set { this[this.Code][SECTION][Inno._GetPropertyName()] = value; }
        }
        public object SIZE_X
        {
            get { return this[this.Code][SECTION][Inno._GetPropertyName()].ToString(); }
            set { this[this.Code][SECTION][Inno._GetPropertyName()] = value; }
        }
        public object SIZE_Y
        {
            get { return this[this.Code][SECTION][Inno._GetPropertyName()].ToString(); }
            set { this[this.Code][SECTION][Inno._GetPropertyName()] = value; }
        }
        public string INFO
        {
            get { return this[this.Code][SECTION][Inno._GetPropertyName()].ToString(); }
            set { this[this.Code][SECTION][Inno._GetPropertyName()] = value; }
        }
    }
}
