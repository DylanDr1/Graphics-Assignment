Shader "Custom/AmbientSpecularShader"
{
    Properties
    {
        _Color("Color", Color) = (1,1,1,1)
        _Shininess("Shininess", Range(0.03, 1)) = 0.078125
        _MainTex("Base (RGB)", 2D) = "white" {}
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200

        CGPROGRAM
        #pragma surface surf BlinnPhong

        sampler2D _MainTex;
        fixed4 _Color;
        half _Shininess;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
           
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;

         

          
            o.Specular = _Shininess; 
        }
        ENDCG
    }
        FallBack "Diffuse"
}
