// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34254,y:32897,varname:node_3138,prsc:2|emission-822-OUT,clip-2665-OUT;n:type:ShaderForge.SFN_Tex2d,id:7646,x:32753,y:32957,varname:node_7646,prsc:2,tex:f684535b3cca7bb46b742829a04c9302,ntxv:0,isnm:False|UVIN-6144-OUT,TEX-6103-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:6103,x:32148,y:32835,ptovrint:False,ptlb:node_6103,ptin:_node_6103,varname:node_6103,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f684535b3cca7bb46b742829a04c9302,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Time,id:6621,x:31939,y:32962,varname:node_6621,prsc:2;n:type:ShaderForge.SFN_Add,id:9690,x:32265,y:33257,varname:node_9690,prsc:2|A-9877-OUT,B-5653-V,C-9888-OUT;n:type:ShaderForge.SFN_Multiply,id:9877,x:32128,y:33045,varname:node_9877,prsc:2|A-6621-TSL,B-4545-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4545,x:31939,y:33133,ptovrint:False,ptlb:_speed,ptin:__speed,varname:node_4545,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-6;n:type:ShaderForge.SFN_TexCoord,id:5653,x:31886,y:33240,varname:node_5653,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:6144,x:32414,y:33241,varname:node_6144,prsc:2|A-8393-OUT,B-9690-OUT;n:type:ShaderForge.SFN_Tex2d,id:7586,x:32734,y:33317,varname:node_7586,prsc:2,tex:f684535b3cca7bb46b742829a04c9302,ntxv:0,isnm:False|TEX-6103-TEX;n:type:ShaderForge.SFN_Add,id:4185,x:33050,y:33273,varname:node_4185,prsc:2|A-7646-R,B-5377-R;n:type:ShaderForge.SFN_Clamp01,id:6212,x:33102,y:33100,varname:node_6212,prsc:2|IN-5590-OUT;n:type:ShaderForge.SFN_RemapRange,id:2665,x:33323,y:33165,varname:node_2665,prsc:2,frmn:0.4,frmx:0.41,tomn:-1,tomx:1|IN-6212-OUT;n:type:ShaderForge.SFN_TexCoord,id:9777,x:31899,y:32464,varname:node_9777,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:7347,x:31915,y:32381,ptovrint:False,ptlb:speed distort,ptin:_speeddistort,varname:node_7347,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Multiply,id:9880,x:32126,y:32303,varname:node_9880,prsc:2|A-6621-TSL,B-7347-OUT;n:type:ShaderForge.SFN_Add,id:9303,x:32198,y:32503,varname:node_9303,prsc:2|A-9880-OUT,B-9777-V;n:type:ShaderForge.SFN_Append,id:2590,x:32409,y:32392,varname:node_2590,prsc:2|A-9777-U,B-9303-OUT;n:type:ShaderForge.SFN_Tex2d,id:8903,x:32672,y:32364,varname:node_8903,prsc:2,tex:f684535b3cca7bb46b742829a04c9302,ntxv:0,isnm:False|UVIN-2590-OUT,TEX-6103-TEX;n:type:ShaderForge.SFN_Multiply,id:9888,x:33014,y:32274,varname:node_9888,prsc:2|A-5877-OUT,B-3423-OUT;n:type:ShaderForge.SFN_RemapRange,id:3423,x:33001,y:32440,varname:node_3423,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-8903-G;n:type:ShaderForge.SFN_ValueProperty,id:5877,x:32738,y:32300,ptovrint:False,ptlb:distort,ptin:_distort,varname:node_5877,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.08;n:type:ShaderForge.SFN_ObjectPosition,id:4981,x:32007,y:34813,varname:node_4981,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:2277,x:31986,y:35019,varname:node_2277,prsc:2;n:type:ShaderForge.SFN_Vector3,id:2951,x:32199,y:34911,varname:node_2951,prsc:2,v1:1,v2:0,v3:0;n:type:ShaderForge.SFN_Subtract,id:1598,x:32421,y:34824,varname:node_1598,prsc:2|A-4981-XYZ,B-2951-OUT;n:type:ShaderForge.SFN_Normalize,id:8029,x:32686,y:34821,varname:node_8029,prsc:2|IN-1598-OUT;n:type:ShaderForge.SFN_Subtract,id:5390,x:32528,y:35014,varname:node_5390,prsc:2|A-4981-XYZ,B-9272-OUT;n:type:ShaderForge.SFN_Append,id:9272,x:32321,y:35141,varname:node_9272,prsc:2|A-2277-X,B-1252-OUT,C-2277-Z;n:type:ShaderForge.SFN_Vector1,id:1252,x:32099,y:35216,varname:node_1252,prsc:2,v1:0;n:type:ShaderForge.SFN_Normalize,id:9135,x:32719,y:35014,varname:node_9135,prsc:2|IN-5390-OUT;n:type:ShaderForge.SFN_Dot,id:2851,x:33000,y:34890,varname:node_2851,prsc:2,dt:0|A-8029-OUT,B-9135-OUT;n:type:ShaderForge.SFN_Cross,id:7715,x:33000,y:35053,varname:node_7715,prsc:2|A-8029-OUT,B-9135-OUT;n:type:ShaderForge.SFN_ArcTan2,id:5195,x:33219,y:34926,varname:node_5195,prsc:2,attp:2|A-2851-OUT,B-7715-OUT;n:type:ShaderForge.SFN_ComponentMask,id:1736,x:33516,y:34968,varname:node_1736,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-5195-OUT;n:type:ShaderForge.SFN_Add,id:8393,x:32052,y:33400,varname:node_8393,prsc:2|A-5653-U,B-1736-OUT;n:type:ShaderForge.SFN_Multiply,id:6966,x:33614,y:34812,varname:node_6966,prsc:2|A-6246-OUT,B-1736-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6246,x:33429,y:34771,ptovrint:False,ptlb:camera offset,ptin:_cameraoffset,varname:node_6246,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:6;n:type:ShaderForge.SFN_Add,id:278,x:32270,y:33880,varname:node_278,prsc:2|A-5631-OUT,B-4786-V,C-4922-OUT;n:type:ShaderForge.SFN_TexCoord,id:4786,x:31897,y:33718,varname:node_4786,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:7145,x:32593,y:33841,varname:node_7145,prsc:2|A-7889-OUT,B-278-OUT;n:type:ShaderForge.SFN_Tex2d,id:5377,x:32783,y:33660,varname:node_5377,prsc:2,tex:f684535b3cca7bb46b742829a04c9302,ntxv:0,isnm:False|UVIN-7145-OUT,TEX-6103-TEX;n:type:ShaderForge.SFN_ValueProperty,id:4514,x:32009,y:33633,ptovrint:False,ptlb:speed2,ptin:_speed2,varname:node_4514,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-2;n:type:ShaderForge.SFN_Multiply,id:5631,x:32213,y:33578,varname:node_5631,prsc:2|A-6621-TSL,B-4514-OUT;n:type:ShaderForge.SFN_Add,id:7889,x:32270,y:33728,varname:node_7889,prsc:2|A-4786-U,B-5021-OUT,C-9888-OUT;n:type:ShaderForge.SFN_Negate,id:5021,x:33614,y:34612,varname:node_5021,prsc:2|IN-6966-OUT;n:type:ShaderForge.SFN_Vector1,id:4922,x:31918,y:33935,varname:node_4922,prsc:2,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:2218,x:31969,y:34334,varname:node_2218,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_RemapRange,id:2174,x:32298,y:34339,varname:node_2174,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-2218-U;n:type:ShaderForge.SFN_Abs,id:6174,x:32546,y:34374,varname:node_6174,prsc:2|IN-2174-OUT;n:type:ShaderForge.SFN_RemapRange,id:2908,x:32797,y:34357,varname:node_2908,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-6174-OUT;n:type:ShaderForge.SFN_Clamp01,id:1554,x:33043,y:34374,varname:node_1554,prsc:2|IN-2908-OUT;n:type:ShaderForge.SFN_OneMinus,id:5766,x:33253,y:34374,varname:node_5766,prsc:2|IN-1554-OUT;n:type:ShaderForge.SFN_Multiply,id:8120,x:33230,y:33561,varname:node_8120,prsc:2|A-4185-OUT,B-5766-OUT;n:type:ShaderForge.SFN_Add,id:5590,x:33271,y:33402,varname:node_5590,prsc:2|A-8120-OUT,B-7586-B;n:type:ShaderForge.SFN_Color,id:3285,x:33696,y:32848,ptovrint:False,ptlb:node_3285,ptin:_node_3285,varname:node_3285,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.291955,c2:0.412764,c3:0.9926471,c4:1;n:type:ShaderForge.SFN_Color,id:7748,x:33792,y:33069,ptovrint:False,ptlb:node_7748,ptin:_node_7748,varname:node_7748,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7763864,c2:0.421,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:822,x:33992,y:32866,varname:node_822,prsc:2|A-3285-RGB,B-7748-RGB,T-8468-OUT;n:type:ShaderForge.SFN_Add,id:8468,x:32991,y:32944,varname:node_8468,prsc:2|A-7646-R,B-7586-B;proporder:6103-4545-7347-5877-6246-4514-3285-7748;pass:END;sub:END;*/

Shader "Shader Forge/lavaShader" {
    Properties {
        _node_6103 ("node_6103", 2D) = "white" {}
        __speed ("_speed", Float ) = -6
        _speeddistort ("speed distort", Float ) = 3
        _distort ("distort", Float ) = 0.08
        _cameraoffset ("camera offset", Float ) = 6
        _speed2 ("speed2", Float ) = -2
        _node_3285 ("node_3285", Color) = (0.291955,0.412764,0.9926471,1)
        _node_7748 ("node_7748", Color) = (0.7763864,0.421,1,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_6103; uniform float4 _node_6103_ST;
            uniform float __speed;
            uniform float _speeddistort;
            uniform float _distort;
            uniform float _cameraoffset;
            uniform float _speed2;
            uniform float4 _node_3285;
            uniform float4 _node_7748;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.pos = UnityObjectToClipPos(v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 node_8029 = normalize((objPos.rgb-float3(1,0,0)));
                float3 node_9135 = normalize((objPos.rgb-float3(_WorldSpaceCameraPos.r,0.0,_WorldSpaceCameraPos.b)));
                float node_1736 = ((atan2(dot(node_8029,node_9135),cross(node_8029,node_9135))/6.28318530718)+0.5).g;
                float4 node_6621 = _Time + _TimeEditor;
                float2 node_2590 = float2(i.uv0.r,((node_6621.r*_speeddistort)+i.uv0.g));
                float4 node_8903 = tex2D(_node_6103,TRANSFORM_TEX(node_2590, _node_6103));
                float node_9888 = (_distort*(node_8903.g*2.0+-1.0));
                float2 node_6144 = float2((i.uv0.r+node_1736),((node_6621.r*__speed)+i.uv0.g+node_9888));
                float4 node_7646 = tex2D(_node_6103,TRANSFORM_TEX(node_6144, _node_6103));
                float2 node_7145 = float2((i.uv0.r+(-1*(_cameraoffset*node_1736))+node_9888),((node_6621.r*_speed2)+i.uv0.g+0.5));
                float4 node_5377 = tex2D(_node_6103,TRANSFORM_TEX(node_7145, _node_6103));
                float4 node_7586 = tex2D(_node_6103,TRANSFORM_TEX(i.uv0, _node_6103));
                clip((saturate((((node_7646.r+node_5377.r)*(1.0 - saturate((abs((i.uv0.r*2.0+-1.0))*2.0+-1.0))))+node_7586.b))*200.0002+-81.00008) - 0.5);
////// Lighting:
////// Emissive:
                float3 emissive = lerp(_node_3285.rgb,_node_7748.rgb,(node_7646.r+node_7586.b));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_6103; uniform float4 _node_6103_ST;
            uniform float __speed;
            uniform float _speeddistort;
            uniform float _distort;
            uniform float _cameraoffset;
            uniform float _speed2;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.pos = UnityObjectToClipPos(v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 node_8029 = normalize((objPos.rgb-float3(1,0,0)));
                float3 node_9135 = normalize((objPos.rgb-float3(_WorldSpaceCameraPos.r,0.0,_WorldSpaceCameraPos.b)));
                float node_1736 = ((atan2(dot(node_8029,node_9135),cross(node_8029,node_9135))/6.28318530718)+0.5).g;
                float4 node_6621 = _Time + _TimeEditor;
                float2 node_2590 = float2(i.uv0.r,((node_6621.r*_speeddistort)+i.uv0.g));
                float4 node_8903 = tex2D(_node_6103,TRANSFORM_TEX(node_2590, _node_6103));
                float node_9888 = (_distort*(node_8903.g*2.0+-1.0));
                float2 node_6144 = float2((i.uv0.r+node_1736),((node_6621.r*__speed)+i.uv0.g+node_9888));
                float4 node_7646 = tex2D(_node_6103,TRANSFORM_TEX(node_6144, _node_6103));
                float2 node_7145 = float2((i.uv0.r+(-1*(_cameraoffset*node_1736))+node_9888),((node_6621.r*_speed2)+i.uv0.g+0.5));
                float4 node_5377 = tex2D(_node_6103,TRANSFORM_TEX(node_7145, _node_6103));
                float4 node_7586 = tex2D(_node_6103,TRANSFORM_TEX(i.uv0, _node_6103));
                clip((saturate((((node_7646.r+node_5377.r)*(1.0 - saturate((abs((i.uv0.r*2.0+-1.0))*2.0+-1.0))))+node_7586.b))*200.0002+-81.00008) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
