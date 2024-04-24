import axios from "axios";
import { useEffect, useState } from "react";
//import * as React from 'react';
//import Stack from '@mui/material/Stack';
import Button from '@mui/material/Button';

function MenuCrud() {
    const [id, setId] = useState("");
    const [name, setName] = useState("");
    const [price, setPrice] = useState("");
    const [type, setType] = useState("");
    const [menus, setMenus] = useState([]);

    useEffect(() => {
        Load();
    }, []);

    async function Load() {
        try {
            const result = await axios.get("https://localhost:7247/api/Menus");
            setMenus(result.data);
        } catch (error) {
            console.error("Error loading Menu:", error);
        }
    }

    async function save(event) {
        event.preventDefault();
        try {
            await axios.post("https://localhost:7247/api/Menus", {
                Name: name,
                Price: price,
                Type: type,
            });
            alert("Food Added Successfully");
            clearFields();
            Load();
        } catch (error) {
            console.error("Error adding food:", error);
        }
    }

    async function editMenu(menu) {
        setId(menu.id);
        setName(menu.name);
        setPrice(menu.price);
        setType(menu.type);
    }

    async function update(event) {
        event.preventDefault();
        try {
            const menuToUpdate = menus.find((u) => u.id === id);
            if (!menuToUpdate) {
                throw new Error("Food not found for update.");
            }
            await axios.put("https://localhost:7247/api/Menus/" + menuToUpdate.id,
                {
                    Id: id,
                    Name: name,
                    Price: price,
                    Type: type,
                }
            );
            alert("Menu Updated");
            clearFields();
            Load();
        } catch (err) {
            alert(err.message);
        }
    }



    async function deleteMenu(id) {
        try {
            await axios.delete("https://localhost:7247/api/Menus/" + id);
            alert("Food Deleted Successfully");
            clearFields();
            Load();
        } catch (error) {
            console.error("Error deleting fooditem:", error);
        }
    }

    const clearFields = () => {
        setId("");
        setName("");
        setPrice("");
        setType("");
    };

    return (
        <div>
            <h1>Menu Details</h1>
            {/* Form to add and update menus */}
            <form>
                {/* Form inputs */}
                <div>
                    <label>Food Name</label>
                    <input
                        type="text"
                        value={name}
                        onChange={(event) => setName(event.target.value)}
                    />
                </div>
                <div>
                    <label>Price</label>
                    <input
                        type="text"
                        value={price}
                        onChange={(event) => setPrice(event.target.value)}
                    />
                </div>
                <div>
                    <label>Type</label>
                    <input
                        type="text"
                        value={type}
                        onChange={(event) => setType(event.target.value)}
                    />
                </div>
                {/* Buttons to add and update */}
                <div>
                    <Button onClick={save} variant="outlined">Add fooditem</Button>
                    <Button onClick={update} variant="outlined">Update fooditem</Button>
                </div>
            </form>
            <br/>
            {/* Table to display menus */}
            <table>
                <thead>
                    <tr>
                        <th>Food Id</th>
                        <th>Food Name</th>
                        <th>Price</th>
                        <th>Type</th>
                        <th>Options</th>
                    </tr>
                </thead>
                <tbody>
                    {menus.map((menu) => (
                        <tr key={menu.id}>
                            <td>{menu.id}</td>
                            <td>{menu.name}</td>
                            <td>{menu.price}</td>
                            <td>{menu.type}</td>
                            <td>
                                {/* Buttons to edit and delete */}
                                <button onClick={() => editMenu(menu)}>Edit</button>
                                <button onClick={() => deleteMenu(menu.id)}>Delete</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default MenuCrud;
