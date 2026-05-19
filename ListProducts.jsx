import React, { useEffect, useState } from 'react'
import { Link } from 'react-router-dom';

export default function ListProducts() {
    const [data, setData] = useState(null);

    useEffect(() => {
        fetch("https://jsonplaceholder.typicode.com/todos")
            .then((res) => res.json())
            .then((data) => setData(data));
    }, []);

    return (
        <div className='row justify-content-center'>
            <h1>Típusok:</h1>
            {data &&
                data.map((item) => {
                    return (
                    <div key={item.id} className="card" style={{ width: "18rem"}}>
                       <Link to={"/tip/" + item.id}>
                        <div class="card-body">
                            <h5 class="card-title">{item.megnevezes}</h5>
                            <p className="card-text">{item.leiras}</p>
                             <img src={item.kepek} class="img-fluid" style={{maxHeight: 200}} />
                        </div>
                        </Link>
                    </div>
                    )
                })}
        </div>
    );

}
