package com.example.demo;

import java.time.LocalDate;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class HelloController {
	@RequestMapping(value = "hoge")
	public ModelAndView foo(ModelAndView mav){
		mav.setViewName("foo");
		return mav;
	}
	
	@RequestMapping(value = "fuga")
	public ModelAndView bar(ModelAndView mav) {
		mav.setViewName("bar");
		return mav;
	}
	
	@RequestMapping(value = "hogehoge")
	public ModelAndView fooParam(ModelAndView mav, @RequestParam("id")int id) {
		System.out.println(String.format("Žó‚¯Žæ‚Á‚½ID: %d", id));
		mav.setViewName("bar");
		return mav;
	}
	
	@RequestMapping(value = "fuga/{id}")
	public ModelAndView barParam(ModelAndView mav, @PathVariable int id) {
		System.out.println(String.format("Žó‚¯Žæ‚Á‚½ID: %d", id));
		mav.setViewName("bar");
		return mav;
	}
	
	@PostMapping(value="transition")
	public ModelAndView transition(ModelAndView mav,@RequestParam("text3")String param){
		mav.addObject("text1",param);
		mav.addObject("text2",LocalDate.now());
		mav.setViewName("transition");
		return mav;
	}
}
