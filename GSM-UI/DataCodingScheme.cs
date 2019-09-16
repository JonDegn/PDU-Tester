using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_UI
{
    public enum DataCodingScheme
    {
        Default_0,
        Flash_16 = 16,
        AutoDelete_64 = 64,
        AutoDelete_Flash_80 = 80,
        Discard_VoicemailInactive_192 = 192,
        Discard_FaxInactive_193 = 193,
        Discard_EmailInactive_194 = 194,
        Discard_OtherInactive_195 = 195,
        Discard_VoicemailActive_200 = 200,
        Discard_FaxActive_201 = 201,
        Discard_EmailActive_202 = 202,
        Discard_OtherActive_203 = 203,
        Store_VoicemailInactive_208 = 208,
        Store_FaxInactive_209 = 209,
        Store_EmailInactive_210 = 210,
        Store_OtherInactive_211 = 211,
        Store_VoicemailActive_216 = 216,
        Store_FaxActive_217 = 217,
        Store_EmailActive_218 = 218,
        Store_OtherActive_219 = 219,
        DataCoding_Flash_240 = 240,
        DataCoding_ME_241 = 241,
        DataCoding_SIM_242 = 242,
        DataCoding_TE_243 = 243
    }
}
