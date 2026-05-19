import React from 'react'
import { useNavigate } from 'react-router-dom';

export default function NewProduct() {
const navigate = useNavigate();

    function Bekuld(event) {
        event.preventDefault();

        let data = {
            kepek: document.getElementById("kepek").value,
            megnevezes: document.getElementById("megnevezes").value,
            leiras: document.getElementById("leiras").value,
        }

         fetch("https://localhost:7082/api/UjTipusok", {
            method: "POST",
            body: JSON.stringify(data),
            headers: {
                "Content-Type" : "application/json"
            }
         })
            .then((res) => {
                alert("Siker!");
                navigate("/")
    })
            .catch((error) => console.log(error));
        
    }

    return (
        <div className='row justify-content-center'>
            <h2>Új termék felvitele</h2>

            <form onSubmit={Bekuld}>
                <label>Termék megnevezése</label><br />
                <input id="megnevezes" type="text" /><br />
                <label>Termék képe</label><br />
                <input id="kepek" type="text" /><br />
                <label>Termék leírása</label><br />
                <input id="leiras" type="text" /><br />

                <button type="submit">Küldés</button>
            </form>
        </div>
    )
}
