Shader "Jesus/GreyScale"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _GreyScaleValue("GreyScale Scale", float) = 0.0
         _Contrast("Contrast", float) = 0.0
          //_Stage("Transition Stage", float) = 0.0
    }
    SubShader
    {
       
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;
            float _GreyScaleValue;
            float _Contrast;
            //float _Stage;

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                //fixed4 c = col;
                col.rgb = ( col.r + col.g + col.b / _GreyScaleValue) * _Contrast;
                return col;
                //return col + (c * _Stage);
            }
            ENDCG
        }
    }
}
