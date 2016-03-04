function Start() {
var a:float=Screen.width;
var b:float=Screen.height;
var h:float=a/b-1.6;
var kuan:float=a/1280;
var gao:float=b/800;
transform.localScale = Vector3(kuan,gao+h,1);
transform.localPosition = Vector3(0, b/2, 0);
}