//================================================================================
//
// _INNO._Custom.Custom_Extensions
//
//================================================================================
//                                   Copyright @ Innosoft 2019. http://innosoft.kr
//                      Copyright @ (주)북스 BOOX, Inc. 2023. http://www.boox.co.kr
//                                   Andy Yang - booxboox@naver.com, 010-3292-3892
//================================================================================
// [생성]
// 1. 작성자 : Andy Yang
// 2. 작성일 : 2025-01-22
//--------------------------------------------------------------------------------
// [설명]
// 1. 고객맞춤 확장 클래스
//--------------------------------------------------------------------------------
// [이력]
// <날짜>    <작성자>    <설명>
// 25-01-22  Andy Yang	Initial.
//================================================================================
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _INNO._Custom
{
    public static class Custom_Extensions
    {
        public static string Concat(this int data, params int[] parameters)
        {
            string ret = data.ToString();
            foreach (var parameter in parameters)
            {
                ret += parameter.ToString();
            }
            return ret;
        }
    }
}
