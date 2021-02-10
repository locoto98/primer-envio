import React, { Component } from 'react'


export default class App extends Component {
    render() {
        const { nombre, telefono } = this.props;
        return (
            <div>
            <h1>Hola Christian</h1>
            <h2>Tu nombre es : {nombre}</h2>
            <h2>Tu telefono es : {telefono}</h2>
            <h1>Expresiones {50*50}</h1>
        </div>
        )
    }
}
