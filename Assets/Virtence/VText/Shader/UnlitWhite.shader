﻿Shader "Custom/UnlitWhite" {
	Properties {
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			o.Albedo = half3(0.0,0.0,0.0);
			o.Alpha = 1.0;
			o.Emission = half3(1.0,1.0,1.0);
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
