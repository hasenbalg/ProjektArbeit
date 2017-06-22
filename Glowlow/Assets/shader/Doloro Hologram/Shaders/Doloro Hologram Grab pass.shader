// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Doloro\Effects\Hologram GP" { 
	Properties { 
		[Header (Textures and Bumpmaps)]_Holomap("Holo map", 2D) = "white" {}
		_Maintexture("Main texture", 2D) = "white" {}
		[Header (Colors)]_Holotint("Holo tint", Color) = (0.4067906,0.7279412,0.7279412,1)
		[Header (Variables)]_EmissionPower("Emission Power", float) = 1
		_Border("Border", float) = 0.3
		_Noisemovment("Noise movment", Vector) = (1,1,0,0)
		_Noisescale("Noise scale", Vector) = (1,200,0,0)
		_Monocolor("Mono color", float) = 0
	}
	SubShader {
		LOD 300
		Tags {
			"Queue" = "Transparent"
			"RenderType" = "Opaque"
		}

		Fog {
			Mode Global
			Density 0
			Color (1, 1, 1, 1) 
			Range 0, 300
		}

		GrabPass {
			Name "BASE"
		}

		Stencil {
			Ref 0
			Comp Always
			Pass Keep
			Fail Keep
			ZFail Keep
		}

		Cull Back
		ZWrite  On
		Lighting   Off
		ColorMask   RGBA

		CGPROGRAM 
		#pragma surface surf BlinnPhong vertex:vert 
		#pragma target 4.0
		#include "UnityCG.cginc"

		sampler2D _Holomap;
		sampler2D _Maintexture;
		float4 _Holotint;
		float _EmissionPower;
		float _Border;
		float2 _Noisemovment;
		float2 _Noisescale;
		float _Monocolor;
		sampler2D _GrabTexture : register(s0);
		uniform half4 _GrabTexture_TexelSize;
		float3 _p0_pi0_nc17_o1;
		float3 _p0_pi0_nc25_o1;
		float _p0_pi0_nc26_o1;
		float _p0_pi0_nc29_o0;
		float3 _p0_pi0_nc31_o2;
		float _p0_pi0_nc32_o0;
		float _p0_pi0_nc33_o2;
		float3 _p0_pi0_nc34_o4;
		float3 _p0_pi0_nc35_o2;
		float2 _p0_pi0_nc39_o0;
		float2 _p0_pi0_nc43_o0;
		float _p0_pi0_nc44_o1;
		float _p0_pi0_nc44_o2;
		float _p0_pi0_nc46_o2;
		float _p0_pi0_nc47_o2;
		float2 _p0_pi0_nc48_o5;
		float2 _p0_pi0_nc54_o2;
		float3 _p0_pi0_nc65_o4;
		float _p0_pi0_nc76_o1;
		float _p0_pi0_nc76_o2;
		float _p0_pi0_nc80_o1;
		float _p0_pi0_nc80_o2;
		float _p0_pi0_nc80_o3;
		float3 _p0_pi0_nc86_o0;
		float _p0_pi0_nc87_o2;
		float _p0_pi0_nc88_o2;
		float2 _p0_pi0_nc89_o0;
		float3 _p0_pi0_nc91_o3;
		float _p0_pi0_nc94_o0;
		float _p0_pi0_nc99_o0;
		float3 _p0_pi0_nc112_o3;
		float3 _p0_pi0_nc114_o3;
		float3 _p0_pi0_nc115_o3;

		struct appdata{
			float4 vertex    : POSITION;  // The vertex position in model space.
			float3 normal    : NORMAL;    // The vertex normal in model space.
			float4 texcoord  : TEXCOORD0; // The first UV coordinate.
			float4 texcoord1 : TEXCOORD1; // The second UV coordinate.
			float4 texcoord2 : TEXCOORD2; // The third UV coordinate.
			float4 tangent   : TANGENT;   // The tangent vector in Model Space (used for normal mapping).
			float4 color     : COLOR;     // Per-vertex color.
		};

		struct Input{
			float2 uv_Holomap;
			float2 uv_Maintexture;
			float3 viewDir;
			float3 worldPos;
			float3 worldRefl;
			float3 worldNormal;
			float4 screenPos;
			float4 color : COLOR;
			float4 proj1;
			float4 position : POSITION;

			INTERNAL_DATA
		};

		half3 Desaturate(half3 c){
			half base = 0.3f * c.r + 0.59f * c.g + 0.11f * c.b;
			return float3(base, base, base);
		}

		void vert (inout appdata v, out Input data){
			UNITY_INITIALIZE_OUTPUT(Input,data);
			data.position = UnityObjectToClipPos(v.vertex);
			data.proj1 = ComputeScreenPos(data.position);
			COMPUTE_EYEDEPTH(data.proj1.z);
			#if UNITY_UV_STARTS_AT_TOP
				data.proj1.y = (data.position.w - data.position.y) * 0.494f;
			#endif
		}

		void surf (Input IN, inout SurfaceOutput o) {
			_p0_pi0_nc17_o1 = _Holotint.rgb;
			_p0_pi0_nc89_o0 = _Noisescale;
			_p0_pi0_nc43_o0 = _Noisemovment;
			_p0_pi0_nc29_o0 = _EmissionPower;
			_p0_pi0_nc94_o0 = _Monocolor;
			_p0_pi0_nc32_o0 = _Border;
			_p0_pi0_nc76_o1 = (_p0_pi0_nc89_o0).x;
			_p0_pi0_nc39_o0 = IN.uv_Maintexture;
			_p0_pi0_nc34_o4 = tex2D(_Maintexture, _p0_pi0_nc39_o0).rgb;
			_p0_pi0_nc35_o2 = (_p0_pi0_nc34_o4 * _p0_pi0_nc17_o1);
			_p0_pi0_nc99_o0 = _Time.y;
			_p0_pi0_nc54_o2 = _p0_pi0_nc43_o0 * _p0_pi0_nc99_o0;
			_p0_pi0_nc44_o1 = (_p0_pi0_nc54_o2).x;
			_p0_pi0_nc44_o2 = (_p0_pi0_nc54_o2).y;
			_p0_pi0_nc76_o2 = (_p0_pi0_nc89_o0).y;
			_p0_pi0_nc86_o0 = IN.worldPos;
			_p0_pi0_nc80_o1 = (_p0_pi0_nc86_o0).x;
			_p0_pi0_nc87_o2 = (_p0_pi0_nc80_o1 * _p0_pi0_nc76_o1);
			_p0_pi0_nc80_o2 = (_p0_pi0_nc86_o0).y;
			_p0_pi0_nc88_o2 = (_p0_pi0_nc80_o2 * _p0_pi0_nc76_o2);
			_p0_pi0_nc46_o2 = (_p0_pi0_nc87_o2 + _p0_pi0_nc44_o1);
			_p0_pi0_nc47_o2 = (_p0_pi0_nc88_o2 + _p0_pi0_nc44_o2);
			_p0_pi0_nc80_o3 = (_p0_pi0_nc86_o0).z;
			_p0_pi0_nc48_o5 = float2(_p0_pi0_nc46_o2, _p0_pi0_nc47_o2);
			_p0_pi0_nc65_o4 = tex2D(_Holomap, _p0_pi0_nc48_o5).rgb;
			_p0_pi0_nc25_o1 = Desaturate(_p0_pi0_nc65_o4);
			_p0_pi0_nc26_o1 = (_p0_pi0_nc25_o1).x;
			_p0_pi0_nc91_o3 = lerp(_p0_pi0_nc35_o2, _p0_pi0_nc17_o1, _p0_pi0_nc94_o0);
			_p0_pi0_nc31_o2 = _p0_pi0_nc91_o3 * _p0_pi0_nc29_o0;
			_p0_pi0_nc33_o2 = max(_p0_pi0_nc26_o1, _p0_pi0_nc32_o0);
			_p0_pi0_nc112_o3 = tex2Dproj(_GrabTexture, IN.proj1 + abs(0 * float4(1.0f, 1.0f, 1.0f, 1.0f) - float4(1.0f, 1.0f, 1.0f, 1.0f) / 16 ) - 1.0f / 8 + 1.0f / 15);
			_p0_pi0_nc114_o3 = lerp(_p0_pi0_nc91_o3, _p0_pi0_nc112_o3, _p0_pi0_nc33_o2);
			_p0_pi0_nc115_o3 = lerp(_p0_pi0_nc31_o2, _p0_pi0_nc112_o3, _p0_pi0_nc33_o2);
			o.Emission = _p0_pi0_nc115_o3;
			o.Albedo = _p0_pi0_nc114_o3;
		}
		ENDCG

	}
	FallBack "Diffuse"
}
