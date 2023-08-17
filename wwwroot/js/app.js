function probar(){
    let name = document.getElementById("name").value;
    /*let param = {
        nombre : name
    }*/
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "/Datos/ProcesarDatos?name="+encodeURIComponent(name), true);
    //xhr.open("POST","Datos/ProcesarDatos",true);
    xhr.responseType = "text";
    xhr.onreadystatechange = function (){
        if(xhr.status == 200 && xhr.readyState == 4){
            let res = xhr.responseText;
            console.log(res)
        }
    };
    //let parametros = JSON.stringify(param);
    xhr.send();
}