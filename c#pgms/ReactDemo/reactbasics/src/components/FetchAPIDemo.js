import React, { useState, useEffect } from 'react'
export const FetchAPIDemo = () => {
    const [todos, setTodos] = useState([])
    useEffect(() => {
        console.log('useEffect')
        fetch("https://jsonplaceholder.typicode.com/todos")
            .then(response => response.json())
            //.then(json => console.log(json))
        .then(json=>setTodos(json))
    }, [])
    const rowdata = todos.map((todo) =>
        <tr key={todo.id}>
            <td>{todo.userId}</td>
            <td>{todo.id}</td>
            <td>{todo.title}</td>
            <td>{String(todo.completed)}</td>
           
        </tr>
    );
    return (
        <div className="container">
            <h1>
                Number of Todos{todos.length }
            </h1>
            <table className="table">
                <thead className="thead-dark">
                    <tr>
                        <td>User Id</td>
                        <td>Id</td>
                        <td>Title</td>
                        <td>Completed</td>
                    </tr>
                </thead>
                <tbody>
                    {rowdata }
                </tbody>
          </table>
        </div>
        )
}