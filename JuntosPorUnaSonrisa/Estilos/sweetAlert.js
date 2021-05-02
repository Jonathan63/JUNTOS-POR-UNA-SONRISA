function VentanaDer() {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: true,
        onOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: 'Eliminado Exitosamentente'
    })

}


$("#TxtBuscar").keyup(function (event) {
    if (event.keyCode === 13) {
        $("#BtnBuscar").click();
    }
});
