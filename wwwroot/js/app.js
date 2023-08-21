function probar(){
    let name = document.getElementById("name").value;
    let lastname = document.getElementById("apellido").value;
    let param = {
        nombre : name,
        lastn : lastname
    }
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "Datos/ProcesarDatos?nombre="+encodeURIComponent(name), true);
    //xhr.open("POST","/Datos/ProcesarDatos",true);
    xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");//=>para metodo GET
    //xhr.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xhr.responseType = "text";
    xhr.onreadystatechange = function (){
        if(xhr.status == 200 && xhr.readyState == 4){
            let res = xhr.responseText
            console.log(res);
        }
    };
    //let parametros = "nombre="+encodeURIComponent(name);//=> para enviar parametros como un texto
    //xhr.send(JSON.parse(param));
    xhr.send();
}