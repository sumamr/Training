import React, { useState } from 'react'
export const SimpleInterest = () => {
    const [principle,setPrinciple] = useState()
    const [rate, setRate] = useState()
    const [time, setTime] = useState()
    const [si, setSi] = useState()
    const calculateInterest = () => {
        let SimpleInterest = (parseFloat(principle) * parseFloat(rate) * parseFloat(time)) / 100
        setSi(SimpleInterest)
    }
    return (
        <div>
            <input value={principle} onChange={(e) => { setPrinciple(e.target.value) }} placeholder="Enter Principle" />
            <input value={rate} onChange={(e) => { setRate(e.target.value) }} placeholder="Enter Rate Of Interest" />
            <input value={time} onChange={(e) => { setTime(e.target.value) }} placeholder="Enter Time" />
            <button onClick={calculateInterest}>Calculate Interest</button>
            <h1>Simple Interest is {si }</h1>


        </div>
        ) 
}